using System;
using System.Collections.Generic;
using System.Text;
using Petshop.Core.DomainService;
using Petshop.Core.Entity;

namespace Petshop.Core.ApplicationService
{
    public class OwnerService : IOwnerService
    {
        private readonly IOwnerRepository _ownerRepository;

        

        public OwnerService(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }


        public Owner CreateOwner(Owner owner)
        {
            return _ownerRepository.CreateOwner(owner);
        }

        public Owner DeleteOwner(int id)
        {
            return _ownerRepository.DeleteOwner(id);
        }

        public List<Owner> GetAllOwners()
        {
            return _ownerRepository.GetAllOwners();
        }

        public Owner UpdateOwner(Owner ownerUpdate, Owner ownerToEdit)
        {
            return _ownerRepository.UpdateOwner(ownerUpdate, ownerToEdit);
        }

        public Owner SortById(int id)
        {
            return _ownerRepository.SortById(id);

        }
    }
}
