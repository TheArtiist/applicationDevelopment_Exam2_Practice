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

        public Pet()
        {
            var generator = new IdGenerator(0);
            var id = generator.CreateId();
            this.Id = (int)id;
        }

    }
}
