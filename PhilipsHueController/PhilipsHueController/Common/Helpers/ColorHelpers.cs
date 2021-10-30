using System.Drawing;

namespace PhilipsHueController.Common.Helpers
{
    public class ColorHelpers
    {
        public static string ConvertColorToHex(Color color)
        {
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }
    }
}
