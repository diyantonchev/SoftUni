using System.Collections.Generic;

namespace Interfaces
{
    interface IDeveloper
    {
        ISet<Project> Projects { get; set; }
    }
}
