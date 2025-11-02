using IdGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zhFelkeszito2.Model
{
    internal class Pet
    {
        public int Id { get; set; }
        public string name { get; set; }
        public bool gender { get; set; }
        public int age { get; set; }
        public int weight { get; set; }
        public string species { get; set; }

        public Pet(double id,string name, bool gender, int age, int weight, string species)
        {
            
            
            var generator = new IdGenerator(0);
            var idd = generator.CreateId();
            this.name = name;
            this.Id = (int)id+(int)idd;
            this.gender = gender;
            this.age = age;
            this.weight = weight;
            this.species = species;

        }

    }
}
