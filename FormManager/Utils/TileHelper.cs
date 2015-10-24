using System;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using EduFormManager.Properties;
using Models;
using Models.Repo;

namespace EduFormManager.Utils
{
    public static class TileHelper
    {
        public class TileFormDataStatusContent
        {
            public TileFormDataStatusContent(string text, Image icon, Color color)
            {
                this.Text = text;
                this.Icon = icon;
                this.Color = color;
            }
            public string Text { get; set; }
            public Image Icon { get; set; }
            public Color Color { get; set; }
        }

        public static TileItemAppearances AppearanceCaption { get; set; }
        public static TileItemAppearances AppearanceCaptionMid { get; set; }
        public static TileItemAppearances AppearanceMid { get; set; }
        public static TileItemAppearances AppearanceText { get; set; }

        static TileHelper()
        {
            AppearanceCaption = new TileItemAppearances();
            AppearanceCaptionMid = new TileItemAppearances();
            AppearanceMid = new TileItemAppearances();
            AppearanceText = new TileItemAppearances();

            AppearanceCaption.Normal.Font = new Font("Segoe UI Light", 14);
            AppearanceCaptionMid.Normal.Font = new Font("Segoe UI Light", 12);
            AppearanceMid.Normal.Font = new Font("Segoe UI", 10);
            AppearanceText.Normal.Font = new Font("Segoe UI", 8);
        }

        public static Tile CreateLoadingTile()
        {
            var tile = new Tile();
            tile.Appearances.Normal.BackColor = Color.White;
            tile.Appearances.Normal.BorderColor = Color.Transparent;
            tile.Properties.ItemSize = TileItemSize.Wide;
            var element = new TileItemElement();
            element.TextAlignment = TileItemContentAlignment.TopCenter;
            element.Appearance.Normal.ForeColor = Color.FromArgb(59, 59, 59);
            element.Appearance.Normal.Font = new Font("Segoe UI Light", 42);
            element.Text = "Загрузка";
            tile.Elements.Add(element);

            var element2 = new TileItemElement();
            element.TextAlignment = TileItemContentAlignment.MiddleCenter;
            element.Appearance.Normal.ForeColor = Color.FromArgb(59, 59, 59);
            element.Appearance.Normal.Font = new Font("Segoe UI Light", 20);
            tile.Elements.Add(element2);
            return tile;
        }

        public static Tile CreateTile(TileItemSize size = TileItemSize.Medium, int elementsCount = 0)
        {
            var tile = new Tile();
            tile.Appearances.Normal.BackColor = Color.FromArgb(0, 114, 198);
            tile.Appearances.Normal.BorderColor = Color.Transparent;
            tile.Properties.ItemSize = size;
            for (var i = 0; i < elementsCount; i++)
            {
                var element = new TileItemElement();
                element.Appearance.Normal.TextOptions.Trimming = Trimming.EllipsisCharacter;
                element.Appearance.Normal.TextOptions.WordWrap = WordWrap.NoWrap;
                tile.Elements.Add(element);
            }
            return tile;
        }
        public static Tile CreateMunitTile(municipality m, bool isArchive = false)
        {
            var mTile = CreateTile(TileItemSize.Medium, 3);
            mTile.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, m, isArchive ? "archive" : "");
            mTile.Elements[0].Appearance.Assign(AppearanceMid);
            mTile.Elements[0].Text = m.name;

            mTile.Elements[1].Appearance.Assign(AppearanceText);
            mTile.Elements[1].TextAlignment = TileItemContentAlignment.BottomLeft;
            mTile.Elements[1].Text = "Образовательных организаций";

            mTile.Elements[2].Appearance.Assign(AppearanceText);
            mTile.Elements[2].TextAlignment = TileItemContentAlignment.BottomRight;
            mTile.Elements[2].Text = m.edus.Count.ToString();
            return mTile;
        }
        public static Tile CreateEduTypeTile(edu_kind eok, Tile mTile, bool isArchive = false)
        {
            var eotTile = CreateTile(TileItemSize.Wide, 1);
            eotTile.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, eok, isArchive ? "archive" : "") + "-" + mTile.Tag;
            eotTile.Elements[0].Text = eok.name;
            eotTile.Elements[0].Appearance.Assign(AppearanceMid);
            return eotTile;
        }

        public static Tile CreateEduTile(edu eo, bool isArchive = false)
        {
            var eoTile = CreateTile(TileItemSize.Wide, 1);
            eoTile.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, eo, isArchive ? "archive" : "");
            eoTile.Elements[0].Text = eo.name;
            eoTile.Elements[0].TextAlignment = TileItemContentAlignment.BottomLeft;
            eoTile.Elements[0].Appearance.Assign(AppearanceMid);
            return eoTile;
        }

        public static Tile CreateAnimatedEduTile(edu eo, bool isArchive = false)
        {
            var eoTile = CreateTile(TileItemSize.Wide, 0);
            eoTile.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, eo, isArchive ? "archive" : "");
            
            var frame1 = new TileItemFrame();
            frame1.Elements.Add(new TileItemElement()
            {
                Text = eo.name,
                TextAlignment = TileItemContentAlignment.BottomLeft
            });
            frame1.Elements[0].Appearance.Assign(AppearanceMid);

            var frame2 = new TileItemFrame();
            frame2.Elements.Add(new TileItemElement()
            {
                TextAlignment = TileItemContentAlignment.BottomLeft
            });
            frame2.Elements[0].Appearance.Assign(AppearanceText);

            eoTile.Frames.Add(frame1);
            eoTile.Frames.Add(frame2);
            eoTile.Properties.ContentAnimation = TileItemContentAnimationType.ScrollLeft;
            eoTile.Properties.FrameAnimationInterval = 3500;
            return eoTile;
        }

        public static object CreateFormTile(IForm fd, IContentContainer parent, bool isArchive = false)
        {
            var dTile = CreateTile(TileItemSize.Wide, 4);
            
            dTile.Tag = TagHelper.GetFormDataTag(TagHelper.TagType.Tile, fd);
            
            dTile.Elements[0].Appearance.Assign(AppearanceMid);
            dTile.Elements[0].Text = fd.form.name;
            dTile.Elements[0].Appearance.Normal.TextOptions.WordWrap = WordWrap.NoWrap;
            dTile.Elements[0].Appearance.Normal.TextOptions.Trimming = Trimming.EllipsisCharacter;
            dTile.Elements[0].ImageAlignment = TileItemContentAlignment.BottomRight;
            dTile.Elements[0].ImageScaleMode = TileItemImageScaleMode.Squeeze;
            dTile.Elements[0].ImageSize = new Size(48, 48);
            dTile.Elements[0].ImageIndex = (int)fd.status;

            dTile.Elements[1].Appearance.Assign(AppearanceText);
            dTile.Elements[1].TextAlignment = TileItemContentAlignment.BottomLeft;

            dTile.Elements[2].TextAlignment = TileItemContentAlignment.MiddleRight;
            dTile.Elements[2].Text = fd.send_date.ToString("yyyy");

            dTile.Elements[3].Appearance.Assign(AppearanceMid);
            dTile.Elements[3].TextAlignment = TileItemContentAlignment.MiddleLeft;
            dTile.Elements[3].Text = string.Format("Срок подачи {0:dd.MM}\nЗагружена {1:dd.MM}", fd.form.submission_date, fd.send_date);

            var doc = new Document
            {
                Tag = TagHelper.GetFormDataTag(TagHelper.TagType.Document, fd),
                Caption = fd.form.name,
                ControlName = string.Format("{1}FormData{0}", fd.form.form_type_id, isArchive ? "Archive" : "")
            };
            
            var page = new Page
            {
                Document = doc,
                Subtitle = doc.Caption,
                Caption = String.Format("{0:d MMMM yyyy}", fd.send_date),
                Tag = TagHelper.GetFormDataTag(TagHelper.TagType.Container, fd),
                Parent = parent
            };
            dTile.ActivationTarget = page;
            return new { Page = page, Document = doc, Tile = dTile };
        }
        
        public static Tile CreateMunitTileForMunicipality(municipality m, bool isArchive = false)
        {
            var mTile = CreateTile(TileItemSize.Wide, 2);
            mTile.Tag = TagHelper.GetTag(TagHelper.TagType.Tile, m, isArchive ? "m-archive" : "m");
            mTile.Elements[0].Appearance.Assign(AppearanceMid);
            mTile.Elements[0].Text = m.name;

            mTile.Elements[1].Appearance.Assign(AppearanceText);
            mTile.Elements[1].TextAlignment = TileItemContentAlignment.BottomLeft;
            return mTile;
        }

        public static Tile CreateQuestionaryTile(questionary questionary, WindowsUIView view, IContentContainer parent)
        {
            var qTile = CreateTile(TileItemSize.Wide, 1);
            qTile.Elements[0].Appearance.Assign(AppearanceMid);
            qTile.Elements[0].Text = questionary.ToString();
            qTile.Tag = TagHelper.GetQuestionaryTag(questionary, TagHelper.TagType.Tile);

            var questionaryDocument = new Document()
            {
                Caption = questionary.ToString(),
                ControlName = "Questionary",
                Tag = TagHelper.GetQuestionaryTag(questionary, TagHelper.TagType.Document)
            };
            var questionaryPage = new Page
            {
                Caption = questionaryDocument.Caption,
                Document = questionaryDocument,
                Parent = parent,
                Tag = TagHelper.GetQuestionaryTag(questionary, TagHelper.TagType.Container)
            };
            qTile.ActivationTarget = questionaryPage;

            view.Documents.Add(questionaryDocument);
            view.ContentContainers.Add(questionaryPage);
            return qTile;
        }

        #region helper methods
        public static TileFormDataStatusContent GetDataTileStatus(IForm fd, ref FormStatusCount sc)
        {
            switch ((Status)fd.status)
            {
                case Status.OK:
                    sc.FormsOkCount++;
                    return new TileFormDataStatusContent("OK", Resources.check_icon, Color.MediumPurple);
                case Status.Expired:
                    sc.FormsWithExpiredDateCount++;
                    return new TileFormDataStatusContent("С опозданием", Resources.clock_icon, Color.PaleVioletRed);
                case Status.WithErrors:
                    sc.FormsWithErrorsCount++;
                    return new TileFormDataStatusContent("С ошибками", Resources.warning_icon, Color.BurlyWood);
                case (Status.WithErrors | Status.Expired):
                    sc.FormsWithBothCount++;
                    return new TileFormDataStatusContent("С ошибками и опозданием", Resources.broken_icon, Color.SlateGray);
                default:
                    return new TileFormDataStatusContent("Неверный статус", Resources.close01_white, Color.Black);
            }
        }

        public static void SetFormTileStatus(Tile dTile, Tile eoTile, Tile eotTile, Tile mTile, IForm fd, ref FormStatusCount sc)
        {
            var tileStatus = GetDataTileStatus(fd, ref sc);

            dTile.Elements[0].Text = fd.form.name;
            dTile.Elements[0].Image = tileStatus.Icon;
            dTile.Elements[1].Text = tileStatus.Text;
            dTile.Elements[3].Text = String.Format("Срок подачи {0:dd.MM}\nЗагружена {1:dd.MM}", fd.form.submission_date, fd.send_date);
            dTile.Appearances.Normal.BackColor = tileStatus.Color;
            dTile.Appearances.Normal.BorderColor = Color.Transparent;
            dTile.Group = tileStatus.Text;
        }
        #endregion
    }
}
