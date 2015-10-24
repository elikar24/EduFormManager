using System;
using System.ComponentModel.DataAnnotations;

namespace Models
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

    [Flags]
    public enum Status : short
    {
        OK = 0,
        Expired = 1,
        WithErrors = 2,
        Default = -1,
        Unknown = -2
    };

    public enum FormType
    {
        None = 0,
        Edu = 1,
        OtherEdu = 2,
        Municipality = 3,
        OtherMunicipality = 4
    }

    public enum LogActionType
    {
        Login = 1,
        Logout = 2
    }

    [Flags]
    public enum AnswerType : short
    {
        [Display(Name = "Галочка")]
        Check = 1,
        [Display(Name = "Текст")]
        Text = 2
    }
}
