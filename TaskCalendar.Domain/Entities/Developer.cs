using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary.Domain.ValueObjects;

namespace GameLibrary.Domain.Entities
{
    public class Developer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Employee Owner { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
