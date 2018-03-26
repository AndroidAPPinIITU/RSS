using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace STO
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Log : ContentPage
	{
		public Log ()
		{
			InitializeComponent ();
		}

        async void Go_login(object sender, EventArgs e)
        {
            
            //var loginKey = User.Login(Email.Text, Password.Text);
            //if (!loginKey.Contains("Error"))
            //{
                await Navigation.PushModalAsync(new MainPage(), false);
                
            //}
            //else
            //{
            //    await Navigation.PushModalAsync(new Events());
            //}
          
        }

        async void Go_reg(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Reg(), false);
        }
    }
}