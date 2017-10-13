using Cooking_Portal.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cooking_Portal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void login_Clicked(object sender, EventArgs e)
        {
            if(username.Text=="Admin" && password.Text == "1234")
            {
                Navigation.PushModalAsync(new Admin.Admin());
                username.Text = "";
                password.Text = "";
            }
            else
            {
                DisplayAlert("LoginFailed", "Sorry Invalid username or password", " OK");
                username.Text = "";
                password.Text = "";
            }
        }

        private void newUser_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SignUP());
        }
    }
}
