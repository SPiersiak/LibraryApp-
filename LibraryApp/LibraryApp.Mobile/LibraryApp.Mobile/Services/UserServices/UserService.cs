﻿using LibraryApp.Mobile.Models;
using LibraryApp.Mobile.Services.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LibraryApp.Mobile.Services.UserServices
{
    public class UserService : IUserService
    {
        public IRequestService _requestService => DependencyService.Get<IRequestService>();
        public async Task<bool> UpdateUserData(User user)
        {
            var uri = $"{Settings.Server_Endpoint}User";
            var result = await _requestService.PutAsync<User>(uri, user);
            return true;
        }
    }
}
