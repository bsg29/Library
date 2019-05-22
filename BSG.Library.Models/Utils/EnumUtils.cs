using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace BSG.Library.Models.Utils
{
    public static class EnumUtils
    {
        public static string GetLocalizedValue(this Enum enumValue)
        {
            var fieldInfo = enumValue
                .GetType()
                .GetField(enumValue.ToString());

            return GetEnumFieldLocalizedValue(fieldInfo);
        }

        public static IDictionary<int, string> GetLocalizedValues(Type enumType)
        {
            var result = enumType
                .GetEnumValues()
                .Cast<object>()
                .ToDictionary(
                    fieldInfo => (int)fieldInfo,
                    fieldInfo => GetEnumFieldLocalizedValue(enumType.GetField(fieldInfo.ToString()))
                );

            return result;
        }

        private static string GetEnumFieldLocalizedValue(FieldInfo fieldInfo)
        {
            var descriptionAttribute = fieldInfo
                .GetCustomAttributes(typeof(DescriptionAttribute), false)
                .Cast<DescriptionAttribute>()
                .FirstOrDefault();

            if (descriptionAttribute == null) return fieldInfo.Name;

            return descriptionAttribute.Description;
        }
    }
}
