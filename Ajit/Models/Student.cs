using System.ComponentModel.DataAnnotations;

namespace Ajit.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime DateofBirth { get; set; }

        [Required]
        public string Standard { get; set; }

    }
}
