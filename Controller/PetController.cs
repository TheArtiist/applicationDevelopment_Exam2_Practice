using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zhFelkeszito2.Dao;
using zhFelkeszito2.Model;

namespace zhFelkeszito2.Controller
{
    internal class PetController
    {
        private readonly IPetDao _petDao;

        public PetController(IPetDao petDao)
        {
            this._petDao = petDao;
        }

        public bool AddPet(Pet pet)
        {
            return _petDao.AddPet(pet);
        }

        public bool UpdatePet(Pet pet)
        {
            return _petDao.UpdatePet(pet);
        }

        public IEnumerable<Pet> GetAllPets() 
        {
            return _petDao.GetAllPets();
        }
    }
}
