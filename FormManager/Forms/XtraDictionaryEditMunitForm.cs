using EduFormManager.Forms.UserControls;
using Models;

namespace EduFormManager.Forms
{
    public partial class XtraDictionaryEditMunitForm : ClientAreaForm
    {
        public XtraDictionaryEditMunitForm(XtraDictionaryMunitControl parentMunitControl, municipality munit)
            : base()
        {
            InitializeComponent();

            this.xtraDictionaryEditMunitControl1.ParentMunitControl = parentMunitControl;
            this.xtraDictionaryEditMunitControl1.Municipality = munit;
            this.xtraDictionaryEditMunitControl1.ControlType = XtraBaseControl.Type.Form;
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
