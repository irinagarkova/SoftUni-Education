using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ValidationAttributes.Attributes;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            if (obj is null) return false;

            var type = obj.GetType();
            var properties = type.GetProperties();

            foreach (var property in properties)
            {
                var validationAttributes = property.GetCustomAttributes<MyValidationAttribute>();
                var propertyValue = property.GetValue(obj);

                foreach (var attribute in validationAttributes)
                {
                    if (!attribute.IsValid(propertyValue)) return false;
                }
            }

            return true;
        }
    }
}
