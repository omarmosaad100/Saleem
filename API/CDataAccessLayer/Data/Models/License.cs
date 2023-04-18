using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDataAccessLayer.Data.Models
{
    public class License
    {
        public Guid Id { get; set; }


        [ForeignKey(nameof(NationalId))]
        public long NationalIdId { get; set; }
        public virtual NationalId NationalId { get; set; }
    }
}