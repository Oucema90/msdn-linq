using msdn_linq_samples.Attribute;

namespace msdn_linq_samples.Enums
{
    public enum LinqOperators
    {
        [ContractMeta("1. Restriction Operators")] Restriction = 1,

        [ContractMeta("2. Projection Operators")] Projection = 2,

        [ContractMeta("3. Partition Operators")] Partition = 3,

        [ContractMeta("4. Ordering Operators")] Ordering = 4,

        [ContractMeta("5. Grouping Operators")] Grouping = 5,

        [ContractMeta("6. Set Operators")] Set = 6,

        [ContractMeta("7. Conversion Operators")] Conversion = 7,

        [ContractMeta("8. Element Operators")] Element = 8,

        [ContractMeta("9. Generation Operators")] Generation = 9,

        [ContractMeta("10. Quantifier Operators")] Quantifier = 10,

        [ContractMeta("11. Aggregate Operators")] Aggregate = 11,

        [ContractMeta("12. Miscellaneous Operators")] Miscellaneous = 12,

        [ContractMeta("13. Query Execution Operators")] QueryExecution = 13,

        [ContractMeta("14. Join Operators")] Join = 14
    }
}
