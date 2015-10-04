using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduFormManager.Utils
{
    public static class EnumExtensions
    {
        public static bool IsMunicipalityForm(this FormType formType)
        {
            return (formType == FormType.Municipality || formType == FormType.OtherMunicipality);
        }

        public static bool IsEduForm(this FormType formType)
        {
            return (formType == FormType.Edu || formType == FormType.OtherEdu);
        }
    }
}
