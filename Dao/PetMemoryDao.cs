using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zhFelkeszito2.Model;

namespace zhFelkeszito2.Dao
{
    internal class PetMemoryDao : IPetDao
    {
        private List<Pet> list = new List<Pet>();
        public bool AddPet(Pet pet)
        {
            if(pet is null)
            {
                return false;
            }else if (list.Any(x => x.Id == pet.Id))
            {
                return false;
            }
            else
            {
                list.Add(pet);
                return true;
            }
                
        }

        public IEnumerable<Pet> GetAllPets()
        {
            return this.list;
        }

        public bool UpdatePet(Pet pet)
        {
            int index = list.IndexOf(list.FirstOrDefault(x => x.Id == pet.Id));

            if (index == -1) 
            {
                return false;
            }
            list[index] = pet;
            return true;

        }
    }
}
