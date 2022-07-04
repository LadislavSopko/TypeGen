using System;
using System.Reflection;

namespace TypeGen.Core.Converters
{
    /// <summary>
    /// Converts PascalCase names to camelCase names
    /// </summary>
    public class AsIsConverter : IMemberNameConverter, ITypeNameConverter
    {
        public AsIsConverter()
        {
        }

        public string Convert(string name, MemberInfo memberInfo)
        {
            return ConvertTypeInvariant(name);
        }

        public string Convert(string name, Type type)
        {
            return ConvertTypeInvariant(name);
        }

        private static string ConvertTypeInvariant(string name)
        {
            return name;
        }
    }
}
