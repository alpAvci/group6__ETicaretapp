using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaratApp.Entities
{
    public partial class SalesVaultAction
    {
        [Key]
        public int SalesVaultId { get; set; }
    }
}
