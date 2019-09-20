using LandBotRD.Web.Data.Entities;
using LandBotRD.Web.Helpers;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LandBotRD.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _dataContext;
        private readonly IuserHelper _userHelper;

        public SeedDb(DataContext dataContext,
            IuserHelper userHelper)
        {
            _dataContext = dataContext;
            _userHelper = userHelper;
        }

        public async Task SeedAsync()
        {
            await _dataContext.Database.EnsureCreatedAsync();
            await CheckRoles();

            var user = await _userHelper.GetUserByEmailAsync("damian.navarrete@outlook.es");
            if (user == null)
            {
                user = new User
                {
                    FirstName = "Damian",
                    LastName = "Navarrete",
                    Email = "damian.navarrete@outlook.es",
                    UserName = "damian.navarrete@outlook.es"
                };

                var result = await _userHelper.AddUserAsync(user, "123456");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }
                await _userHelper.AddUserToRoleAsync(user, "Admin");
            }
            var isInRole = await _userHelper.IsUserInRoleAsync(user, "Admin");
            if (!isInRole)
            {
                await _userHelper.AddUserToRoleAsync(user, "Admin");
            }

        }

        private async Task CheckRoles()
        {
            await _userHelper.CheckRoleAsync("Admin");
            await _userHelper.CheckRoleAsync("Usuario");
        }
    }
}
