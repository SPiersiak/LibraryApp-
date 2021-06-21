﻿using LibraryApp.Mobile.Views;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace LibraryApp.Mobile.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public Command LogoutCommand { get; }
        private string fullName;
        private string text;
        private string role;
        public AboutViewModel()
        {
            Title = "About";
            
            LogoutCommand = new Command(Logout);
            MessagingCenter.Subscribe<LoginViewModel, string>(this, "name",  (sender, arg) =>
            {
                FullName = arg;
            });
            MessagingCenter.Subscribe<LoginViewModel, string>(this, "role", (sender, arg) =>
            {
                Role = arg;
                UserInfo();
            });


        }
        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }
        public string Role
        {
            get => role;
            set => SetProperty(ref role, value);
        }
        public string FullName
        {
            get => fullName;
            set => SetProperty(ref fullName, value);
        }
        private void UserInfo()
        {
            if(Role == "Anonnymous")
            {
                FullName = "Anonimowy uzytkownik";
                Text = "Jako anonimowy uzytkonik kontynuj z ograniczonymi możliwościami\n" +
                    "Zapraszamy do przegladania zbiorów biblioteki";
            }
            else if(Role == "Tak")
            {
                //FullName = Settings.FirstName + " " + Settings.LastName;
                Text = "Bibliotekarzu zapraszamy do zarządzania biblioteka";
            }
            else if (Role == "Nie")
            {
                //FullName = Settings.FirstName + " " + Settings.LastName;
                Text = "Cytelniku zapraszamy do korzystania z biblioteki";
            }
        }
        private async void Logout()
        {
            Settings.UserId = "Anonnymous";
            Settings.FirstName = "Anonnymous";
            Settings.LastName = "Anonnymous";
            Settings.Email = "Anonnymous";
            Settings.UserName = "Anonnymous";
            Settings.Password = "Anonnymous";
            Settings.Role = "Anonnymous";
            var x = new AppViewModel();
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}