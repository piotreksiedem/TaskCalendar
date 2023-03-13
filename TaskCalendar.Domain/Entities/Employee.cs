using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary.Domain.ValueObjects;

namespace GameLibrary.Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public PersonName PersonName { get; set; }
        public Developer Developer { get; set; }
    }
}
