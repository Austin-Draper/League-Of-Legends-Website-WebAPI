using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterWebAPI.Models
{
    public class Roster
    {
        [Key]
        public int PMId { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string ChampionName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Lane { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Tag1 { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Tag2 { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Tag3 { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Tag4 { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Tag5 { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Tag6 { get; set; }

    }
}
