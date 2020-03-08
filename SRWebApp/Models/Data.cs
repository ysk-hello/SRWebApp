using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRWebApp.Models
{
    public class Data
    {
        public int MemberId { get; set; }

        public Member Member { get; set; }

        public DateTime DateTime { get; set; }

        public int FollowerNum { get; set; }
    }
}
