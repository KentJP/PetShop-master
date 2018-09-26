using Petshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop.Core.DomainService
{
    public interface IOwnerRepository
    {
        Owner CreateOwner(Owner owner);

        IEnumerable<Owner> GetAllOwners();

        Owner UpdateOwner(Owner ownerUpdate);

        Owner DeleteOwner(int id);
        Owner SortById(int id);
    }

}

