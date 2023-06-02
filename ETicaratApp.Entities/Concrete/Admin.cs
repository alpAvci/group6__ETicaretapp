using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretApp.EntitiesLayer.Concrete;

namespace ETicaretApp.EntitiesLayer.Concrete
{
    public partial class Admin
    {
        [Key]
        public int AdminId { get; set; }


        public string UserName { get; set; }
        public string Password { get; set; }
        public string Authority { get; set; }





    }
}
