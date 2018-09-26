using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Petshop.Core.DomainService;
using Petshop.Core.Entity;

namespace Petshop.Infrastructure.Data.Repositories
{
    public class PetRepository : IPetRepository
    {
        public readonly PetAppContext _ptx;
        public PetRepository(PetAppContext ptx)
        {
            _ptx = ptx;

        }
        public Pet Create(Pet pet)
        {
            /*/ if (pet.PreviousOwner!=null && _ptx.ChangeTracker.Entries<Owner>().FirstOrDefault(ow=> ow.Entity.id == pet.PreviousOwner.id ) == null)
             {
                 _ptx.Attach(pet.PreviousOwner);
             }
             var animal = _ptx.Pets.Add(pet).Entity;
             _ptx.SaveChanges();
            return animal;
            /*/
            _ptx.Attach(pet).State = EntityState.Added;
            _ptx.SaveChanges();
            return pet;
        }

        public Pet Delete(int id)
        {
           // var petsToRemove = _ptx.Pets.Where(p => p.Id == id);
            //_ptx.RemoveRange(petsToRemove);
            var petRemoved=_ptx.Remove<Pet>(new Pet {Id = id}).Entity;
            _ptx.SaveChanges();
            return petRemoved;
        }

        public IEnumerable<Pet> GetAllPets()
        {
            return _ptx.Pets;
        }

        public Pet SortById(int id)
        {
            return _ptx.Pets.Include(p => p.PreviousOwner).FirstOrDefault(p => p.Id == id);

        }

        public IEnumerable<Pet> SortByType()
        {
            return _ptx.Pets;

        }

        public Pet Update(Pet PetUpdate)
        {
            /*/ if (PetUpdate.PreviousOwner !=null)
             {
                 _ptx.Attach(PetUpdate.PreviousOwner);
             }
             else
             {
                 _ptx.Entry(PetUpdate).Reference(p => p.PreviousOwner).IsModified = true;
             }

             var updated = _ptx.Update(PetUpdate).Entity;
             _ptx.SaveChanges();
             return updated;
             /*/
            _ptx.Attach(PetUpdate).State = EntityState.Modified;
            _ptx.SaveChanges();
            return PetUpdate;
        }
    }
}
