using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Infrastructure.Enums
{
    public enum Title : byte
    {
        [Description("Select Title")]
        Empty = 0,
        [Description("Mr")]
        Mister,
        [Description("Mrs")]
        Misus,
        [Description("Dr")]
        Doctor,
        [Description("Ms")]
        Miss,
        [Description("Hon")]
        Honourable
    }
}
