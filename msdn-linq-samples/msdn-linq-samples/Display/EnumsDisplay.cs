using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using msdn_linq_samples.Attribute;
using msdn_linq_samples.Provider;
using msdn_linq_samples.Display;

namespace msdn_linq_samples.Display
{
    public static class EnumsDisplay
    {
        public static void DisplayProgramMenu()
        {
            var programMenu = DataProvider.GetLinqOperators();
            foreach (var item in programMenu)
            {
                Console.WriteLine(item.DisplayName());
            }
        }

        public static string DisplayName(this Enum enumValue)
        {
            var declaredField = enumValue
                .GetType()
                .GetTypeInfo()
                .GetDeclaredField(enumValue.ToString());

            var contractMeta = declaredField == null ? null : declaredField.GetCustomAttribute<ContractMetaAttribute>();

            return contractMeta != null ? contractMeta.DisplayName : enumValue.ToString();
        }
    }
}
