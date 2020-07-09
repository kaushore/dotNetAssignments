using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FirstCoreWebApp.Models
{
    public class Product
    {
        [Required(ErrorMessage = "ID missing")]
        public int Pid { get; set; }

        [Required(ErrorMessage = "Name missing")]
        public string Pname { get; set; }

        [Required(ErrorMessage = "Price missing")]
        public float Price { get; set; }

        [Required(ErrorMessage = "Stock missing")]
        public int Stock { get; set; }
    }
}
