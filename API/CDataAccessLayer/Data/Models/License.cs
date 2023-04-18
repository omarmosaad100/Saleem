using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDataAccessLayer.Data.Models
{
    public class License
    {
        public Guid Id { get; set; }


        [RegularExpression("^[23]\\d{2}(0[1-9]|1[0-2])(0[1-9]|[12]\\d|3[01])\\d{7}$")]
        [ForeignKey(nameof(National))]
        public string NationalId { get; set; }
        public virtual National National { get; set; }
    }
}