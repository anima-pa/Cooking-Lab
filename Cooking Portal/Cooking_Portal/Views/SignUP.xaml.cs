using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cooking_Portal.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignUP : ContentPage
	{
		public SignUP ()
		{
			InitializeComponent ();
		}

        
        private void signup_Clicked(object sender, EventArgs e)
        {
            if (password.Text == repassword.Text)
            {
                if (firstname.Text!=null && lastname.Text!=null && username.Text != null)
                {
                    DisplayAlert("Data Saved", "Registeration Success", "OK");
                }
                else
                {
                    DisplayAlert("Data Not Saved", "Missing Data", "OK");
                }
            }
            else
            {
                DisplayAlert("Data Not Saved", "Registeration Failed.. Password didnt match", "OK");
            }
        }
    }
}