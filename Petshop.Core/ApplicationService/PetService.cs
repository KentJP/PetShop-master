using Petshop.Core.DomainService;
using Petshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Petshop.Core.ApplicationService
{
    public class PetService : IPetService
    {

        readonly IPetRepository _PetRepo;

        public PetService(IPetRepository PetRepository)
        {
            _PetRepo = PetRepository;
        }

        

        public Pet Delete(int id)
        {
           
            return _PetRepo.Delete(id);
        }

        public List<Pet> GetAllPets()
        {
            return _PetRepo.GetAllPets();
        }

        public List<Pet> GetCheapestPets()
        {
            return _PetRepo.GetAllPets()
                .OrderBy(pet => pet.Price).Take(9).ToList();
        }

        public Pet SortById(int id)
        {
            return _PetRepo.SortById(id);
        }

        

        public List<Pet> SortByType()
        {
            return _PetRepo.GetAllPets()
                .OrderBy(pet => pet.Type)
                .ToList();
        }

        public Pet Update(Pet PetUpdate, Pet petToEdit)
        {
            var pet = SortById(PetUpdate.Id);
            petToEdit.Name = PetUpdate.Name;
            petToEdit.Type = PetUpdate.Type;
            petToEdit.Color = PetUpdate.Color;
            petToEdit.PreviousOwner = PetUpdate.PreviousOwner;
            petToEdit.SoldDate = PetUpdate.SoldDate;
            petToEdit.Birthdate = PetUpdate.Birthdate;
           
            petToEdit.Price = PetUpdate.Price;
            

            return petToEdit;
        }

        public Pet GetPetInstance()

        {
            return new Pet();

        }

        public Pet Create(Pet pet)
            
        {
            return _PetRepo.Create(pet);
        }

        public object Create()
        {
            throw new NotImplementedException();
        }

        public Pet NewPet(string Name, string Type, string Color, string PreviousOwner, double price)
        {
            var petss = new Pet()
            {
                Name = Name,
                Type = Type,
                Color = Color,
                PreviousOwner = PreviousOwner,
                Price = price,
                
                
            };

            return petss;
        }
    }
}
    

