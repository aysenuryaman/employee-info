using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Kipas.Models
{
    public class State
    {
        public State()
        {
            Employees = new HashSet<Employee>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
