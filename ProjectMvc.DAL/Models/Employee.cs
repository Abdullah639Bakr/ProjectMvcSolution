using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMvc.DAL.Models
{
    public class Employee : BaseEntity
    {
        //public int Id { get; set; }

        [Required(ErrorMessage ="Name Is Required")]
        public string Name { get; set; }
        [Range(25,60 , ErrorMessage = " Age Must Be Between 25 And 60")]
        public int? Age { get; set; }
        public string Address { get; set; }

        [Required(ErrorMessage = "Salary Is Required")]
        public decimal Salary { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]

        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime HiringDate { get; set; }
        public DateTime DateOfCreation { get; set; }



    }
}
