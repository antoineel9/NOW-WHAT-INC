using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new3.Data
{
    public class GED
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VID { get; set; }

        public string STUDENTINFO { get; set; }
        public string CLASSES { get; set; }
        public string EMPLOYED { get; set; }
        public string Racine { get; set; }
        public string Milwaukee { get; set; }
        public string Kenosha { get; set; }
    }
}