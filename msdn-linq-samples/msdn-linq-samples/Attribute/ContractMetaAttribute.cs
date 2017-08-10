using System;

namespace msdn_linq_samples.Attribute
{
    public class ContractMetaAttribute : System.Attribute
    {
        public ContractMetaAttribute(string displayName)
        {
            DisplayName = displayName;
        }

        public string DisplayName { get; }
    }
}
