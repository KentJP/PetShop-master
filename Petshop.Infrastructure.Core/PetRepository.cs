using Petshop.Core.DomainService;
using Petshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using Petshop.Infrastructure.Core;

namespace Petshop.Infrastructure.Data
{
    public class PetRepository : IPetRepository
    {

        static int Id = 0;
        private List<Pet> Pets = new List<Pet>();
        
        

        public Pet Create(Pet pet)
        {
            Id = Id++;
            var pets = FakeDB.Pets.ToList();
            FakeDB.Pets = pets;
            pets.Add(pet);
            return pet;

        }

        public Pet Delete(int id)
        {
            var PetFound = this.SortById(id);
            if (PetFound != null)
            {
                FakeDB.Pets.Remove(PetFound);
                return PetFound;
            }

            return null;
        }

        public List<Pet> GetAllPets()
        {
            return FakeDB.Pets;
        }

        

        public Pet SortById(int id)
        {
            
            foreach (var Pet in FakeDB.Pets)
            {
                if (Pet.Id == id)
                {
                    return Pet;
                }
            }
            return null;
        }

       

        public List<Pet> SortByType()
        {
            return null;
        }

        public Pet Update(Pet PetUpdate)
        {
            var PetFromFakeDB = this.SortById(PetUpdate.Id);
            if (PetFromFakeDB != null)
            {
                PetFromFakeDB.Name = PetUpdate.Name;
                PetFromFakeDB.Type = PetUpdate.Type;
                PetFromFakeDB.Color = PetUpdate.Color;
                PetFromFakeDB.Birthdate = PetUpdate.Birthdate;
                PetFromFakeDB.PreviousOwner = PetUpdate.PreviousOwner;
                PetFromFakeDB.Price = PetUpdate.Price;
                PetFromFakeDB.SoldDate = PetUpdate.SoldDate;
                return PetFromFakeDB;
            }
            return null;
        }
       
    }
    } 
