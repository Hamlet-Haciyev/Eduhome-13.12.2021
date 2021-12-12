using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Position { get; set; }
        [MaxLength(2000)]
        public string About { get; set; }
        [MaxLength(100)]    
        public string Degree { get; set; }
        [MaxLength(100)]
        public string Experience { get; set; }
        [MaxLength(100)]
        public string Faculty { get; set; }
        [MaxLength(50)]
        public string Mail { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        [MaxLength(30)]
        public string Skype { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        public  List<Teacher_Hobbie> Teacher_Hobbies { get; set; }
        public List<TeacherToSocial> TeacherToSocials { get; set; }
        public List<Teacher_Skill> Teacher_Skills { get; set; }

    }
}
