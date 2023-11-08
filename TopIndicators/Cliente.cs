using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.ComponentModel.DataAnnotations;

namespace TopIndicators
{
    public class Cliente
    {
        public int ID_Cliente { get; set; }

        [Required]
        [StringLength(255)]
        public string Nome { get; set; }
    }
}
