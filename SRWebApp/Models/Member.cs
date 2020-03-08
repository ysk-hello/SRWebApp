using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SRWebApp.Models
{
    public class Member
    {
        public int MemberId { get; set; }

        public string Name { get; set; }

        public int RoomId { get; set; }

        [Display(Name = "Team")]
        public int TeamId { get; set; }

        public Team Team { get; set; }
    }
}
