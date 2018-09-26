using Petshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop.Core.ApplicationService
{
    public interface IOwnerService
    {
        Owner CreateOwner(Owner owner);

        IEnumerable<Owner> GetAllOwners();

        Owner UpdateOwner(Owner ownerUpdate);

        Owner DeleteOwner(int id);
        Owner SortById(int id);
    }
}
