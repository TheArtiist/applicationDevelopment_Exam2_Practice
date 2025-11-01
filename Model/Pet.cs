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
        public string gender { get; set; }
        public int age { get; set; }
        public double weight { get; set; }
        public string species { get; set; }

        public Pet(string name, bool gender, int age, double weight, string species)
        {
            var generator = new IdGenerator(0);
            var id = generator.CreateId();
            this.Id = (int)id;
            this.name = name;
            if (gender)
            {
                this.gender = "nőstény";
            }
            else
            {
                this.gender = "hím";
            }
                this.age = age;
            this.weight = weight;
            this.species = species;

        }

    }
}
