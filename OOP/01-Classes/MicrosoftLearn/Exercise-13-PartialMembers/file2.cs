using System;

namespace Exercise_13_PartialMembers
{
    public partial class PropertyBag
    {
        // Defining declaration
        public partial int MyProperty { get => field; set; }
    }
}
