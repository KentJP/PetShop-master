using Petshop.Core.DomainService;
using Petshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Petshop.Infrastructure.Core;

namespace Petshop.Infrastructure.Data
{
    public class OwnerRepository : IOwnerRepository
    {
        private static int id = 0;

        public Owner CreateOwner(Owner owner)
        {
            id = id++;
            var owners = FakeDB.OwnersList.ToList();
            FakeDB.OwnersList = owners;
            owners.Add(owner);
            return owner;
        }

        public Owner DeleteOwner(int id)
        {
            var OwnerFound = this.SortById(id);
            if (OwnerFound !=null)
            {
                FakeDB.OwnersList.Remove(OwnerFound);
            }

            return null;
        }

        public List<Owner> GetAllOwners()
        {
            return FakeDB.OwnersList;
        }

        public Owner UpdateOwner(Owner ownerUpdate, Owner ownerToEdit)
        {
            var OwnerFromFakeDb = this.SortById(ownerUpdate.id);
            if (OwnerFromFakeDb != null)
            {
                OwnerFromFakeDb.FirstName = ownerUpdate.FirstName;
                OwnerFromFakeDb.LastName = ownerUpdate.LastName;
                OwnerFromFakeDb.Address = ownerUpdate.Address;
                OwnerFromFakeDb.Email = ownerUpdate.Email;
                OwnerFromFakeDb.PhoneNumber = ownerUpdate.PhoneNumber;

                return OwnerFromFakeDb;

            }
            return null;
        }

        public Owner SortById(int id)
        {

            foreach (var Owner in FakeDB.OwnersList)
            {
                if (Owner.id == id)
                {
                    return Owner;
                }
            }
            return null;
        }
    }
}
