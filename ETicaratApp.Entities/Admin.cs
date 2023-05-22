using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaratApp.Entities
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Column(Type = "Varchar")]
        [StringLength(10)]
        public string UserName { get; set; }

        [Column(Type = "Varchar")]
        [StringLength(10)]
        public string Password { get; set; }

        [Column(Type = "Varchar")]
        [StringLength(1)]
        public string Authority { get; set; }   


    }
}
