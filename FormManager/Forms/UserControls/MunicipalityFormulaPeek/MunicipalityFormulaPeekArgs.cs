using System.Collections.Generic;
using Models;

namespace EduFormManager.Forms.UserControls.MunicipalityFormulaPeek
{
    public class MunicipalityFormulaPeekArgs
    {
        public MunicipalityFormulaPeekArgs(byte[] formulaBytes, IList<IForm> formDataList, bool write)
        {
            this.FormulaBytes = formulaBytes;
            this.FormDataList = formDataList;
            this.Write = write;
        }

        public MunicipalityFormulaPeekArgs()
        {
            this.FormDataList = new List<IForm>();
            this.Write = false;
        }

        public byte[] FormulaBytes { get; set; }
        public IList<IForm> FormDataList { get; private set; }
        public bool Write { get; set; }
    }
}
