using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduFormManager.Properties;
using Models;

namespace EduFormManager.Utils
{
    public class TileResources
    {
        public static Dictionary<Status, Color> FormDataColors =
            new Dictionary<Status, Color>()
            {
                { Status.OK, Color.FromArgb(155, 89, 182) },
                { Status.Expired, Color.FromArgb(214, 69, 65) },
                { Status.WithErrors, Color.FromArgb(235, 149, 50) },
                { Status.WithErrors | Status.Expired, Color.FromArgb(103, 128, 159) },
                { Status.Default, Color.FromArgb(52, 73, 94) },
                { Status.Unknown, Color.DarkRed }
            };

        public static Dictionary<Status, string> FormDataText =
            new Dictionary<Status, string>()
            {
                {Status.OK, "ОК"},
                {Status.Expired, "Опоздания"},
                {Status.WithErrors, "Ошибки"},
                {Status.WithErrors | Status.Expired, "Ошибки и опоздания"},
                {Status.Default, "Пусто"},
                {Status.Unknown, "Остальные"}
            };

        public static Dictionary<Status, Image> FormDataIcons =
            new Dictionary<Status, Image>()
            {
                { Status.OK, Resources.Checked_32 },
                { Status.Expired, Resources.Expired_32 },
                { Status.WithErrors, Resources.Attention_32 },
                { Status.WithErrors | Status.Expired, Resources.Cancel_32 },
                { Status.Default, Resources.Empty_32 },
                { Status.Unknown, Resources.Empty_32 }
            };

        public static Color AccentColor = Color.FromArgb(37, 116, 169);
        public static Color FontColor = Color.FromArgb(59, 59, 59);
    }
}
