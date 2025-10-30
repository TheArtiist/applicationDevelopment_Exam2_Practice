using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zhFelkeszito2.Model;

namespace zhFelkeszito2.Dao
{
    internal interface IPetDao
    {
        public bool AddPet(Pet pet);
        public bool UpdatePet(Pet pet);
        IEnumerable<Pet> GetAllPets();
    }
}
