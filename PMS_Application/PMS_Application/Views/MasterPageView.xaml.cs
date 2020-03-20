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
	public partial class MasterPageView : MasterDetailPage
	{
		public MasterPageView ()
		{
			InitializeComponent ();
            //Detail = new NavigationPage(new DashboardPageView());
            var nav = new NavigationPage
            {
                Title = "Dashboard"
            };
            nav.PushAsync(new DashboardPageView() { Title = "Dashboard" });
            nav.BarBackgroundColor = Color.FromHex("#bf1e2d");

            Detail = nav;
            IsPresented = false;
        }

        private void Leave_Onclicked(object sender, EventArgs e)
        {
            Detail.Navigation.PushAsync(new LeavePageView());
            IsPresented = false;
        }

        private void LogOut_OnCLick(object sender, EventArgs e)
        {
            App.Current.MainPage= new LoginPageView();
          
        }
    }
}