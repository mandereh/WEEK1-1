namespace Week1TestClass.CSharpSyntax
{
    public static class ExtensionMethodsAKAHelpers
    {
        public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T?> source) where T : class
        {
            foreach(var item in source)
            {
                if (item != null)
                {
                    yield return item;
                }
            }
        }
    }
}