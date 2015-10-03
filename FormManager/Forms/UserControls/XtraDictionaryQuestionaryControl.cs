using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using EduFormManager.Models;
using EduFormManager.Models.Repo;
using EduFormManager.Properties;

namespace EduFormManager.Forms.UserControls
{
    public partial class XtraDictionaryQuestionaryControl : XtraBaseControl, ISupportDocumentActions
    {
        private questionary _currentQuestionary;
        public XtraDictionaryQuestionaryControl(WindowsUIView view, Repository repo) 
            : base(view)
        {
            InitializeComponent();

            InitializeBindings();
            InitializeContextMenu();
        }

        private void InitializeContextMenu()
        {
            this.gridControlQuestions.ContextMenu = new ContextMenu();
            this.gridControlQuestions.ContextMenu.Popup += (s, e) =>
            {
                var menu = s as ContextMenu;

                var delItem = new MenuItem("Удалить", (sender, args) =>
                {
                    var question = GetSelectedRow(this.gridViewQuestions) as question;
                    if (question == null || _currentQuestionary == null) return;

                    _currentQuestionary.questions.Remove(question);
                    this.questionBindingSource.Remove(question);
                });
                menu.MenuItems.Clear();
                menu.MenuItems.Add(delItem);
            };

            this.gridControlAnswers.ContextMenu = new ContextMenu();
            this.gridControlAnswers.ContextMenu.Popup += (s, e) =>
            {
                var menu = s as ContextMenu;
                var delItem = new MenuItem("Удалить", (sender, args) =>
                {
                    var answer = GetSelectedRow(this.gridViewAnswers) as answer;
                    var question = this.questionBindingSource.Current as question;
                    if (answer == null || question == null) return;
                    
                    question.answers.Remove(answer);
                    this.answerBindingSource.Remove(answer);
                });
                menu.MenuItems.Clear();
                menu.MenuItems.Add(delItem);
            };
        }

        private object GetSelectedRow(GridView view)
        {
            return view.GetRow(view.FocusedRowHandle);
        }

        private void InitializeBindings()
        {
            
        }

        public questionary CurrentQuestionary
        {
            set
            {
                if (value == null) throw new ArgumentNullException();
                _currentQuestionary = value;
                this.gridControlQuestions.DataSource = _currentQuestionary.questions;
            }
            get
            {
                return _currentQuestionary;
            }
        }

        protected override async void Save(Document doc)
        {
            if (_currentQuestionary.questionary_id == 0)
                Repo.Db.questionaries.Add(_currentQuestionary);
            await Repo.Db.SaveChangesAsync();
        }

        public void OnQueryDocumentActions(IDocumentActionsArgs args)
        {
            args.DocumentActions.Add(new DocumentAction((x) =>
            {
                if (_currentQuestionary == null)
                    return;
                _currentQuestionary.questions.Add(new question()
                {
                    question_title = "Новый вопрос", 
                    questionary = _currentQuestionary, 
                    answers = new HashSet<answer>()
                });
                this.gridControlQuestions.DataSource = null;
                this.gridControlQuestions.DataSource = _currentQuestionary.questions;
            })
            {
                Caption = "Добавить вопрос", 
                Image = Resources.glyphicons_432_plus
            });
            args.DocumentActions.Add(new DocumentAction((x) =>
            {
                var currentQuestion = this.gridViewQuestions.GetRow(this.gridViewQuestions.FocusedRowHandle) as question;
                if (currentQuestion == null)
                    return;

                currentQuestion.answers.Add(new answer()
                {
                    answer_title = "Ответ", question = currentQuestion, answer_type = (int) AnswerType.Check
                });
                this.gridControlAnswers.DataSource = null;
                this.gridControlAnswers.DataSource = currentQuestion.answers;
            })
            {
                Caption = "Добавить вариант ответа", 
                Image = Resources.glyphicons_432_plus
            });
            args.DocumentActions.Add(new DocumentAction(Save) { Caption = "Сохранить все", Image = Resources.glyphicons_206_ok_2 });
        }

        private void gridViewQuestions_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            var currentQuestion = this.questionBindingSource.Current as question;
            if (currentQuestion == null)
                return;
            this.gridControlAnswers.DataSource = currentQuestion.answers;
        }
    }}
