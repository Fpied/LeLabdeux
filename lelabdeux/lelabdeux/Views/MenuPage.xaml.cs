using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lelabdeux.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
		}

		void CounterButtonClicked(object sender, System.EventArgs e)
		{
			this.Navigation.PushAsync(new CountPage());
		}

        void TabsButtonClicked(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new TabsPage());
        }

        void ListeButtonClicked(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new ListPage());
        }

        


    }
}