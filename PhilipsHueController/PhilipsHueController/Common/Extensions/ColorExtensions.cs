using System.Drawing;

namespace PhilipsHueController.Common.Extensions
{
    public static class ColorExtensions
    {
        public static string ConvertToHex(this Color color)
        {
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }
    }
}
