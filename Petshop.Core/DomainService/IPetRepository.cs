using Petshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop.Core.DomainService
{
    public interface IPetRepository
    {

        Pet Create(Pet pet);
        IEnumerable<Pet> GetAllPets();
        Pet Update(Pet PetUpdate);
        Pet Delete(int id);
        Pet SortById(int id);
        IEnumerable<Pet> SortByType();
        
        
        

    }
}
