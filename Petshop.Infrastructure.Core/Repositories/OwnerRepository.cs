using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Petshop.Core.DomainService;
using Petshop.Core.Entity;

namespace Petshop.Infrastructure.Data.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        public readonly PetAppContext _ptx;
        public OwnerRepository(PetAppContext ptx)
        {
            _ptx = ptx;

        }
        public Owner CreateOwner(Owner owner)
        {
            var owners = _ptx.Owners.Add(owner).Entity;
            return owners;
        }

        public Owner DeleteOwner(int id)
        {
            var ownerRemoved = _ptx.Remove<Owner>(new Owner { id = id }).Entity;
            _ptx.SaveChanges();
            return ownerRemoved;
        }

        public IEnumerable<Owner> GetAllOwners()
        {
            return _ptx.Owners;
        }

        public Owner SortById(int id)
        {
            return _ptx.Owners.Include(p => p.PetsList)
                .FirstOrDefault(o => o.id == id);
        }

        public Owner UpdateOwner(Owner ownerUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
