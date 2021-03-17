using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterWebAPI.Models
{
    public class StaticChamp
    {
        [Key]
        public int PMId { get; set; }

        [Required]
        [Column(TypeName ="nvarchar(50)")]
        public string ChampionName { get; set; }

        [Required]
        public bool Assassin { get; set; }

        [Required]
        public bool Fighter { get; set; }

        [Required]
        public bool Mage { get; set; }

        [Required]
        public bool Marksman { get; set; }

        [Required]
        public bool Support { get; set; }

        [Required]
        public bool Tank { get; set; }

    }
}
