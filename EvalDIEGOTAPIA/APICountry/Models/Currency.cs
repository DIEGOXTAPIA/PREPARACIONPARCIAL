using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APICountry.Models
{
    public class Currency
    {
        [Key]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(5,MinimumLength =1, ErrorMessage ="INGRESE ENTRE 1 A 5 CARACTERES")]
        public string Symbol { get; set; }


    }
}