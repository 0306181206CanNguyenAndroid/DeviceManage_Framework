using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DTO.ModelBase
{
    public class DecentralizationModelBase
    {
        public  int Id { get; set; }
        public  int UserId { get; set; }
        public  int TeacherId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }

    }
}
