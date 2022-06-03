using System;

namespace Kipas.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Position { get; set; }
        public string Notes { get; set; }

        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public int? StateId { get; set; }
        public virtual State State { get; set; }
        public string Address { get; set; }

    }
}
