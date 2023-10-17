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
	public partial class CountPage : ContentPage
	{
		int count = 0;
		public CountPage ()
		{
			InitializeComponent ();
		}

		void CountButtonClick(object sender, System.EventArgs e)
		{
			count++;

			countLabel.Text = count.ToString();
            // Console.WriteLine("Bouton cliqué!");
        }
	}
}