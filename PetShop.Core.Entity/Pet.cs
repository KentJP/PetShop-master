using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop.Core.Entity
{
    class Pet

    {
        int Id { get; set; }
        string Type { get; set; }
        string Name { get; set; }
        string Color { get; set; }
        string PreviousOwner { get; set; }
        DateTime Birthdate { get; set; }
        DateTime SoldDate { get; set; }
        double Price { get; set; }

        
    }
}
