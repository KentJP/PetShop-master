using Petshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop.Core.ApplicationService
{
    public interface IPetService
    {

        Pet Create(Pet pet);
       List<Pet> GetAllPets();
        Pet Update(Pet PetUpdate);
        Pet Delete(int id);
        Pet SortById(int id);
        IEnumerable<Pet> SortByType();
        
        IEnumerable<Pet> GetCheapestPets();
        Pet GetPetInstance();
        object Create();
        Pet NewPet(string Name,string Type,string Color,string PreviousOwner,double price);
    }
}
