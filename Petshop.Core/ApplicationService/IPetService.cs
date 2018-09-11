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
        Pet Update(Pet Pet, Pet petToEdit);
        Pet Delete(int id);
        Pet SortById(int id);
        List<Pet> SortByType();
        
        List<Pet> GetCheapestPets();
        Pet GetPetInstance();
        object Create();
        Pet NewPet(string Name,string Type,string Color,string PreviousOwner,double price);
    }
}
