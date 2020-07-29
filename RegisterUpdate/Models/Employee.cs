using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegisterUpdate.Models.Enums;

namespace RegisterUpdate.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; }
        public string Address { get; set; }
        public Level Level { get; set; }
        public string Cep { get; set; }
        public string Telephone { get; set; }
        public string EmergenceTelephone { get; set; }
        public ICollection<Dependent> Dependents { get; set; }

        public Employee()
        {

        }

        public Employee(int id, string name, Status status, string address, Level level, string cep, string telephone, string emergenceTelephone)
        {
            Id = id;
            Name = name;
            Status = status;
            Address = address;
            Level = level;
            Cep = cep;
            Telephone = telephone;
            EmergenceTelephone = emergenceTelephone;
        }

        public void AddDependent(Dependent dp)
        {
            Dependents.Add(dp);
        }

        public void RemoveDependent(Dependent dp)
        {
            Dependents.Remove(dp);
        }
    }
}
