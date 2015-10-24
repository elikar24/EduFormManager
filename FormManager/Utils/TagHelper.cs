using System;
using System.Text.RegularExpressions;
using Models;
using Models.Repo;

namespace EduFormManager.Utils
{
    public static class TagHelper
    {
        public const string FEDERAL_EDU_FORMS_TAG = "EduForms";
        public const string ARCHIVE_FEDERAL_EDU_FORMS_TAG = "ArchiveEduForms";
        public const string ADDON_EDU_FORMS_TAG = "AddonEduForms";
        public const string ARCHIVE_ADDON_EDU_FORMS_TAG = "ArchiveAddonEduForms";
        public const string FEDERAL_MUNIT_FORMS_TAG = "MunitForms";
        public const string ARCHIVE_FEDERAL_MUNIT_FORMS_TAG = "ArchiveMunitForms";
        public const string QUESTIONARY_TAG = "Questionary";

        public const string MUNICIPALITY = "municipality";
        public const string EDU = "edu";
        public const string EDU_TYPE = "edu_type";

        public enum TagType
        {
            Tile,
            Document,
            Container,
            Form
        }
        public static String GetFormDataTag(TagType type, IForm fd)
        {
            switch (type)
            {
                case TagType.Tile:
                    return String.Format("tile-data-{0}-form_type-{1}", fd.id, fd.form.form_type_id);
                case TagType.Document:
                    return String.Format("doc-data-{0}-form_type-{1}", fd.id, fd.form.form_type_id);
                case TagType.Container:
                    return String.Format("container-data-{0}-form_type-{1}", fd.id, fd.form.form_type_id);
                default:
                    return null;
            }
        }

        public static String GetFormContainerTag(edu edu, FormType type, bool isArchive)
        {
            return String.Format("{2}-container-edu-{0}-form_type-{1}", edu.edu_id, (int)type,isArchive ? "archive" : "");
        }

        public static String GetFormContainerTag(municipality m, FormType type, bool isArchive)
        {
            return String.Format("{2}-container-munit-{0}-form_type-{1}", m.municipality_id, (int)type, isArchive ? "archive" : "");
        }

        public static String GetFormContainerTag(edu edu, form_type type, bool isArchive)
        {
            return String.Format("{2}-container-edu-{0}-form_type-{1}", edu.edu_id, type.form_type_id, isArchive ? "archive" : "");
        }

        public static String GetFormContainerTag(municipality m, form_type type, bool isArchive)
        {
            return String.Format("{2}container-munit-{0}-form_type-{1}", m.municipality_id, type.form_type_id, isArchive ? "archive" : "");
        }

        public static String GetTag(TagType type, object obj, string addon = "")
        {
            var tag = String.Format("{0}-{1}", (
                obj is edu ? EDU + "-"+((edu)obj).edu_id 
                : obj is municipality ? MUNICIPALITY + "-"+((municipality)obj).municipality_id 
                : obj is edu_kind ? EDU_TYPE + "-"+((edu_kind)obj).edu_kind_id : "ent"), addon);
            switch (type)
            {
                case TagType.Tile:
                    return "tile-" + tag;
                case TagType.Document:
                    return "doc-" + tag;
                case TagType.Container:
                    return "container-" + tag;
                default:
                    return null;
            }
        }

        public static int? GetId(string tag)
        {
            var dataIdPattern = new Regex(@"\w+-(?<num>\d+)");
            var dataIdMatch = dataIdPattern.Match(tag);
            if (dataIdMatch.Success)
            {
                var dataId = -1;
                var isParsed = Int32.TryParse(dataIdMatch.Groups["num"].Value, out dataId);
                return !isParsed ? null : new int?(dataId);
            }
            return null;
        }

        public static int? GetFormDataId(string tag)
        {
            var dataIdPattern = new Regex(@"data-(?<num>\d+)");
            var dataIdMatch = dataIdPattern.Match(tag);
            if (dataIdMatch.Success)
            {
                var dataId = -1;
                var isParsed = Int32.TryParse(dataIdMatch.Groups["num"].Value, out dataId);
                return !isParsed ? null : new int?(dataId);
            }
            return null;
        }

        public static int? GetMunicipalityId(string tag)
        {
            var dataIdPattern = new Regex(MUNICIPALITY + @"-(?<num>\d+)");
            var dataIdMatch = dataIdPattern.Match(tag);
            if (dataIdMatch.Success)
            {
                var dataId = -1;
                var isParsed = Int32.TryParse(dataIdMatch.Groups["num"].Value, out dataId);
                return !isParsed ? null : new int?(dataId);
            }
            return null;
        }

        public static string GetQuestionaryTag(questionary q, TagType tagType)
        {
            switch (tagType)
            {
                case TagType.Tile:
                    return string.Format("tile-questionary-{0}", q.questionary_id);
                case TagType.Container:
                    return string.Format("container-questionary-{0}", q.questionary_id);
                case TagType.Document:
                    return string.Format("document-questionary-{0}", q.questionary_id);
                default:
                    return null;
            }
            return null;
        }

        public static int? GetQuestionaryId(string tag)
        {
            var idPattern = new Regex(@"questionary-(?<num>\d+)");
            var idMatch = idPattern.Match(tag);
            if (idMatch.Success)
            {
                var id = -1;
                var isParsed = Int32.TryParse(idMatch.Groups["num"].Value, out id);
                return !isParsed ? null : new int?(id);
            }
            return null;
        }
    }
}
