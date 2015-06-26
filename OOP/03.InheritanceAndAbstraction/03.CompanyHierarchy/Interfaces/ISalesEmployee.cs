using System.Collections.Generic;

namespace Interfaces
{
    interface ISalesEmployee
    {
        ISet<Sale> Sales { get; set; }
    }
}
