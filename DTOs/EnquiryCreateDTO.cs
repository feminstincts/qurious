using System.ComponentModel.DataAnnotations;

namespace Qurious.DTOs
{
    public class EnquiryCreateDTO
    {
        [Required]
        [MaxLength(250)]
        public string Question {get; set;}
        [Required]
        public string Answer {get; set;}
        public int? Difficulty {get; set;}
    }
}