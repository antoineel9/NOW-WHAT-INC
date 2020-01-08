using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new3.Data
{
    public class Mentor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string MID { get; set; }

        public string LifeSkills { get; set; }
        public string ContinuingEd { get; set; }
        public string YouthCoach { get; set; }
    }
}