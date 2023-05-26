using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaratApp.Entities.Concrete
{
    public partial class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }

        public string CommentUserName { get; set; }
        public string CommentEmail { get; set; }
        public string CommentTitle { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommentStatus { get; set; }


        public virtual Product Product { get; set; }

        public virtual Customer Customer { get; set; }

    }
}
