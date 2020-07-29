using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterUpdate.Models
{
    public class Dependent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Kinship { get; set; }
        public DateTime Birthday { get; set; }
        public string Cpf { get; set; }
        public bool Odont { get; set; }
        public bool Medic { get; set; }
        public bool Tax { get; set; }

        public Dependent()
        {

        }
        public Dependent(int id, string name, string kinship, DateTime birthday, string cpf, bool odont, bool medic, bool tax)
        {
            Id = id;
            Name = name;
            Kinship = kinship;
            Birthday = birthday;
            Cpf = cpf;
            Odont = odont;
            Medic = medic;
            Tax = tax;
        }
    }
}
