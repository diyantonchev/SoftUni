using System;

namespace Interfaces
{
    interface ISale
    {
        string ProductName { get; set; }
        
        DateTime Date { get; set; }
        
        double Price { get; set; }
    }
}
