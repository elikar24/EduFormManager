using System;
using System.Collections.Generic;
using EduFormManager.Forms.UserControls;
using Models;

namespace EduFormManager.Forms
{
    public partial class XtraDictionaryEditEduForm : ClientAreaForm
    {
        public XtraDictionaryEditEduForm(XtraDictionaryEduControl parentEduControl, List<municipality> municipalityList, List<edu_kind> kindList, edu edu)
            : base()
        {
            InitializeComponent();

            this.xtraDictionaryEditEduControl1.ParentEduControl = parentEduControl;

            this.xtraDictionaryEditEduControl1.MunicipalityDataSource = municipalityList;
            this.xtraDictionaryEditEduControl1.EduKindDataSource = kindList;
            this.xtraDictionaryEditEduControl1.Edu = edu;
            this.xtraDictionaryEditEduControl1.ControlType = XtraBaseControl.Type.Form;
        }

        private void xtraDictionaryEditEduControl1_Load(object sender, EventArgs e)
        {

        }

        //private const int CP_NOCLOSE_BUTTON = 0x200;
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams myCp = base.CreateParams;
        //        myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
        //        return myCp;
        //    }
        //}
    }
}
