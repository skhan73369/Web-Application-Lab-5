using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Category is required")]
        [StringLength(20, ErrorMessage = "First Name must be between 2-20 chractes long")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Category is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Category is required")]
        [DataType(DataType.Date)]
        public string BirthDate { get; set; }
        
        public int Age {
            get
            {
                if (BirthDate != null)
                {
                    int year = Int32.Parse(BirthDate.Substring(0, 4));
                    return DateTime.Now.Year - year;
                }
                else
                {
                    return 0;
                }
            }
         }



    }
    
}
