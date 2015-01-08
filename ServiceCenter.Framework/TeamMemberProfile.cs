﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.Framework
{
    [Serializable]
    public class TeamMemberProfile
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Location { get; set; }
    }
}
