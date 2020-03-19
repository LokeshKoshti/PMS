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
            Detail = new NavigationPage(new DashboardPageView());
		}
	}
}