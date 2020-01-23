using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NWI2.Data
{
    public class GED
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VID { get; set; }

        public string STUDENTINFO { get; set; }
        public string CLASSES { get; set; }
        public string EMPLOYED { get; set; }
        public string LOCATION { get; set; }

    }
}
