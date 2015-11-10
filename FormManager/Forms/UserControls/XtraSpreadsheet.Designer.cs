using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraLayout;
using DevExpress.XtraSpreadsheet;

namespace EduFormManager.Forms.UserControls
{
    partial class XtraSpreadsheet
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraSpreadsheet));
            this.spreadsheetControl = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.toolStripForm = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonForms = new System.Windows.Forms.ToolStripDropDownButton();
            this.windowsUIButtonPanelActions = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.comboBoxDate = new System.Windows.Forms.ComboBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.flyoutPanelActions = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControlActions = new DevExpress.Utils.FlyoutPanelControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.labelWarnEditDisabled = new DevExpress.XtraEditors.LabelControl();
            this.buttonMenuFlyout = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.eduTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatedFormDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduKindBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).BeginInit();
            this.toolStripForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelActions)).BeginInit();
            this.flyoutPanelActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControlActions)).BeginInit();
            this.flyoutPanelControlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // spreadsheetControl
            // 
            this.spreadsheetControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spreadsheetControl.Location = new System.Drawing.Point(12, 56);
            this.spreadsheetControl.Name = "spreadsheetControl";
            this.spreadsheetControl.Size = new System.Drawing.Size(830, 437);
            this.spreadsheetControl.TabIndex = 0;
            this.spreadsheetControl.Text = "spreadsheetControl1";
            this.spreadsheetControl.DocumentLoaded += new System.EventHandler(this.spreadsheetControl_DocumentLoaded);
            this.spreadsheetControl.CellValueChanged += new DevExpress.XtraSpreadsheet.CellValueChangedEventHandler(this.spreadsheetControl_CellValueChanged);
            // 
            // toolStripForm
            // 
            this.toolStripForm.AutoSize = false;
            this.toolStripForm.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripForm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripForm.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonForms});
            this.toolStripForm.Location = new System.Drawing.Point(62, 12);
            this.toolStripForm.Name = "toolStripForm";
            this.toolStripForm.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripForm.Size = new System.Drawing.Size(197, 36);
            this.toolStripForm.TabIndex = 7;
            this.toolStripForm.Text = "toolStrip1";
            // 
            // toolStripDropDownButtonForms
            // 
            this.toolStripDropDownButtonForms.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonForms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.toolStripDropDownButtonForms.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonForms.Image")));
            this.toolStripDropDownButtonForms.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonForms.Name = "toolStripDropDownButtonForms";
            this.toolStripDropDownButtonForms.Size = new System.Drawing.Size(31, 33);
            this.toolStripDropDownButtonForms.Text = "...";
            // 
            // windowsUIButtonPanelActions
            // 
            this.windowsUIButtonPanelActions.BackColor = System.Drawing.Color.White;
            this.windowsUIButtonPanelActions.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton()});
            this.windowsUIButtonPanelActions.ContentAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.windowsUIButtonPanelActions.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.windowsUIButtonPanelActions.Location = new System.Drawing.Point(263, 12);
            this.windowsUIButtonPanelActions.Name = "windowsUIButtonPanelActions";
            this.windowsUIButtonPanelActions.Padding = new System.Windows.Forms.Padding(6);
            this.windowsUIButtonPanelActions.Size = new System.Drawing.Size(432, 55);
            this.windowsUIButtonPanelActions.TabIndex = 8;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.windowsUIButtonPanelActions);
            this.layoutControl1.Controls.Add(this.comboBoxDate);
            this.layoutControl1.Controls.Add(this.toolStripForm);
            this.layoutControl1.Location = new System.Drawing.Point(3, 6);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1047, 287, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(707, 87);
            this.layoutControl1.TabIndex = 9;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // comboBoxDate
            // 
            this.comboBoxDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxDate.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.comboBoxDate.FormattingEnabled = true;
            this.comboBoxDate.ItemHeight = 21;
            this.comboBoxDate.Location = new System.Drawing.Point(62, 52);
            this.comboBoxDate.Name = "comboBoxDate";
            this.comboBoxDate.Size = new System.Drawing.Size(197, 29);
            this.comboBoxDate.TabIndex = 8;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlGroup1.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(707, 87);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.toolStripForm;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(74, 25);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(251, 40);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Форма";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(47, 21);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.comboBoxDate;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(74, 25);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(251, 27);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Год";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(47, 21);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.windowsUIButtonPanelActions;
            this.layoutControlItem5.Location = new System.Drawing.Point(251, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(436, 67);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // flyoutPanelActions
            // 
            this.flyoutPanelActions.Controls.Add(this.flyoutPanelControlActions);
            this.flyoutPanelActions.Location = new System.Drawing.Point(101, 61);
            this.flyoutPanelActions.Name = "flyoutPanelActions";
            this.flyoutPanelActions.OptionsButtonPanel.AllowGlyphSkinning = true;
            this.flyoutPanelActions.OptionsButtonPanel.ButtonPanelContentAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.flyoutPanelActions.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Bottom;
            this.flyoutPanelActions.OptionsButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.Utils.PeekFormButton("Закрыть", global::EduFormManager.Properties.Resources.close01_black, -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Закрыть", false, -1, true, null, true, false, true, null, "Close", -1, false)});
            this.flyoutPanelActions.OwnerControl = this;
            this.flyoutPanelActions.Size = new System.Drawing.Size(711, 115);
            this.flyoutPanelActions.TabIndex = 10;
            // 
            // flyoutPanelControlActions
            // 
            this.flyoutPanelControlActions.Controls.Add(this.layoutControl1);
            this.flyoutPanelControlActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControlActions.FlyoutPanel = this.flyoutPanelActions;
            this.flyoutPanelControlActions.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControlActions.Name = "flyoutPanelControlActions";
            this.flyoutPanelControlActions.Size = new System.Drawing.Size(711, 115);
            this.flyoutPanelControlActions.TabIndex = 0;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.labelWarnEditDisabled);
            this.layoutControl2.Controls.Add(this.buttonMenuFlyout);
            this.layoutControl2.Controls.Add(this.spreadsheetControl);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(633, 415, 250, 350);
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(854, 505);
            this.layoutControl2.TabIndex = 11;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // labelWarnEditDisabled
            // 
            this.labelWarnEditDisabled.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWarnEditDisabled.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.labelWarnEditDisabled.Appearance.Image = global::EduFormManager.Properties.Resources.Attention_26;
            this.labelWarnEditDisabled.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelWarnEditDisabled.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelWarnEditDisabled.Location = new System.Drawing.Point(12, 12);
            this.labelWarnEditDisabled.Name = "labelWarnEditDisabled";
            this.labelWarnEditDisabled.Size = new System.Drawing.Size(695, 40);
            this.labelWarnEditDisabled.StyleController = this.layoutControl2;
            this.labelWarnEditDisabled.TabIndex = 5;
            this.labelWarnEditDisabled.Text = "Редактирование формы отключено, так как срок сдачи истек. Чтобы иметь возможность" +
    " редактировать эту форму, обратитесь к администратору.";
            // 
            // buttonMenuFlyout
            // 
            this.buttonMenuFlyout.AllowFocus = false;
            this.buttonMenuFlyout.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMenuFlyout.Appearance.Options.UseFont = true;
            this.buttonMenuFlyout.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.buttonMenuFlyout.Location = new System.Drawing.Point(742, 12);
            this.buttonMenuFlyout.MaximumSize = new System.Drawing.Size(100, 0);
            this.buttonMenuFlyout.MinimumSize = new System.Drawing.Size(100, 0);
            this.buttonMenuFlyout.Name = "buttonMenuFlyout";
            this.buttonMenuFlyout.Size = new System.Drawing.Size(100, 28);
            this.buttonMenuFlyout.TabIndex = 4;
            this.buttonMenuFlyout.TabStop = false;
            this.buttonMenuFlyout.Text = "Меню";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.emptySpaceItem2,
            this.layoutControlItem4,
            this.layoutControlItem6});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.Size = new System.Drawing.Size(854, 505);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.spreadsheetControl;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 44);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(834, 441);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(699, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(31, 44);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.buttonMenuFlyout;
            this.layoutControlItem4.Location = new System.Drawing.Point(730, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(104, 44);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.labelWarnEditDisabled;
            this.layoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(699, 44);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // XtraSpreadsheet
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flyoutPanelActions);
            this.Controls.Add(this.layoutControl2);
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "XtraSpreadsheet";
            this.Size = new System.Drawing.Size(854, 505);
            ((System.ComponentModel.ISupportInitialize)(this.eduTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatedFormDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduKindBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBindingSource)).EndInit();
            this.toolStripForm.ResumeLayout(false);
            this.toolStripForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelActions)).EndInit();
            this.flyoutPanelActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControlActions)).EndInit();
            this.flyoutPanelControlActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SpreadsheetControl spreadsheetControl;
        private ToolStrip toolStripForm;
        private ToolStripDropDownButton toolStripDropDownButtonForms;
        private WindowsUIButtonPanel windowsUIButtonPanelActions;
        private LayoutControl layoutControl1;
        private ComboBox comboBoxDate;
        private LayoutControlGroup layoutControlGroup1;
        private LayoutControlItem layoutControlItem1;
        private FlyoutPanel flyoutPanelActions;
        private FlyoutPanelControl flyoutPanelControlActions;
        private LayoutControlItem layoutControlItem2;
        private LayoutControl layoutControl2;
        private LayoutControlGroup layoutControlGroup2;
        private LayoutControlItem layoutControlItem3;
        private EmptySpaceItem emptySpaceItem2;
        private LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton buttonMenuFlyout;
        private LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.LabelControl labelWarnEditDisabled;
        private LayoutControlItem layoutControlItem6;
    }
}
