﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Shop.Web.Data.Entities;

namespace Shop.Web.Helpers
{
    public class UseHelper : IUserHelper

    {
        private readonly UserManager<User> userManager;

        public UseHelper(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }
        public async Task<IdentityResult> AddUserAsync(User user, string password)
        {
            return await this.userManager.CreateAsync(user, password);
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {             
            return await this.userManager.FindByEmailAsync(email); 
        }
    }
}
