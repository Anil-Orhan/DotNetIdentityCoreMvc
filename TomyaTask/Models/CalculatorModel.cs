using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace TomyaTask.Models
{
    public class CalculatorModel
    {


        [Required]
        [BindProperty]
        public string hesap { get; set; }
        [Required]
        [BindProperty]
        public string hesapText { get; set; }    
        public string sonuc { get; set; }



    }
}
