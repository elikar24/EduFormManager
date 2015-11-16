using System;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using EduFormManager.Properties;
using Models;
using Models.Repo;

namespace EduFormManager.Forms.UserControls
{
    public partial class XtraMessageControl : XtraBaseControl, ISupportDocumentActions
    {
        public enum MessageTypeEnum
        {
            RequestForQuery,
            BugReport
        }

        private MessageTypeEnum _messageType;

        public XtraMessageControl(WindowsUIView view, Repository repo) 
            : base(view, repo)
        {
            InitializeComponent();
            this.formBindingSource.DataSourceChanged += formBindingSource_DataSourceChanged;
        }

        void formBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            this.comboBoxForm.Properties.Items.Clear();
            this.comboBoxForm.Properties.Items.AddRange(this.formBindingSource.List);
        }

        public MessageTypeEnum MessageType
        {
            set
            {
                _messageType = value;
                TrigControlsByMessageType(value);
            }
            get
            {
                return _messageType;
            }
        }

        private void TrigControlsByMessageType(MessageTypeEnum type)
        {
            switch (type)
            {
                case MessageTypeEnum.RequestForQuery:
                    this.label1.Visible = true;
                    this.comboBoxForm.Visible = true;
                    this.label2.Text = "Сообщение, запрос на форму, вопрос и т.д.";
                    this.textBoxMessage.Text = "";
                    break;
                case MessageTypeEnum.BugReport:
                    this.label1.Visible = false;
                    this.comboBoxForm.Visible = false;
                    this.textBoxMessage.Visible = true;
                    this.comboBoxForm.Properties.Items.Clear();
                    this.comboBoxForm.SelectedItem = null;
                    this.label2.Text = "Опишите последовательность действий, при которой возникает обнаруженная вами ошибка";
                    this.textBoxMessage.Text = "";
                    break;
            }
        }

        public bool CanSend()
        {
            return CanSend(null);
        }

        public bool CanSend(Document doc)
        {
            switch (_messageType)
            {
                case MessageTypeEnum.RequestForQuery:
                    return comboBoxForm.SelectedItem != null && !string.IsNullOrEmpty(textBoxMessage.Text);
                case MessageTypeEnum.BugReport:
                    return !string.IsNullOrEmpty(textBoxMessage.Text);
                default:
                    return false;
            }
        }

        public void Send()
        {
            Send(null);
        }

        public async void Send(Document doc)
        {
            if (!this.CanSend())
            {
                base.ShowFlyoutMessageBox("Ошибка", "Сообщение не должно содержать пустых полей.", FlyoutCommand.OK);
                return;
            }
            try
            {
                var edu = await Repo.GetEdu(Authentication.Credentials.EduId);
                var message = new message()
                {
                    body = this.textBoxMessage.Text,
                    edu = edu,
                    send_date = DateTime.Now
                };
                switch (_messageType)
                {
                    case MessageTypeEnum.RequestForQuery:
                        message.subject = string.Format("Сообщение от {0}", edu);
                        break;
                    case MessageTypeEnum.BugReport:
                        message.subject = "Ошибка";
                        break;
                    default:
                        return;
                }
                Repo.Add(message);
                await Repo.SaveChangesAsync();
                this.ShowFlyoutMessageBox("Информация", "Сообщение отправлено", FlyoutCommand.OK);
            }
            catch (Exception ex)
            {
                this.ShowFlyoutMessageBox("Ошибка", ex.Message);
            }
            //EmailMessaging.SendMessage(message.Subject, message.Body);
        }

        public void OnQueryDocumentActions(IDocumentActionsArgs args)
        {
            args.DocumentActions.Add(new DocumentAction(Send) { Caption = "Отправить", Image = Resources.Feedback_26 });
        }
    }
}
