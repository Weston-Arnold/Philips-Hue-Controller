namespace PhilipsHueController.Common.Extensions
{
    public static class ObjectExtensions
    {
        public static string GetObjectPropertyByName(this object targetObject, string propertyName)
        {
            return targetObject
                .GetType()
                .GetProperty(propertyName)
                .GetValue(targetObject, null)
                .ToString();
        }
    }
}
