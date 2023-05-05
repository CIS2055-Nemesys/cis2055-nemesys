﻿using Microsoft.AspNetCore.Identity;
using nemesis.Models;

namespace nemesis.ViewModels
{
    public class HallOfFameViewModel
    {
        public int TopUsers { get; set; }
        public IEnumerable<IdentityUser> Users { get; set; }
    }
}
