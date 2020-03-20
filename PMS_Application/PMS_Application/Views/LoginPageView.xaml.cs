using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PMS_Application.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPageView : ContentPage
	{
		public LoginPageView ()
		{
			InitializeComponent();
        }

        private void login_clicked(object sender, EventArgs e)
        {
         App.Current.MainPage = new MasterPageView();
        }
    }
}