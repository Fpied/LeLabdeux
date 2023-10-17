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

	public class Article
	{
		public String Nom { get; set; }
        public String Prix { get; set; }
		public String Description { get; set; }
    }

	public partial class ListPage : ContentPage
	{
		List<Article> articles;

		public ListPage ()
		{
			InitializeComponent ();

			articles = new List<Article>();
			articles.Add(new Article { Nom = "Pain au chocolat", Prix = "1€", Description="Chocolatine"});
            articles.Add(new Article { Nom = "Coca", Prix = "2€", Description = "cola" });
            articles.Add(new Article { Nom = "Pizza", Prix = "14€", Description = "3 fromages" });
            articles.Add(new Article { Nom = "Chips", Prix = "1,80€", Description = "poulet de bretz" });

            maListView.ItemsSource = articles;

            maListView.ItemSelected += (sender, e) =>
			{
				if (maListView.SelectedItem != null)
				{
					Article item = maListView.SelectedItem as Article;

                    DisplayAlert(item.Nom, item.Description, "OK");
                    maListView.SelectedItem = null;

                }
				
				
			};

        }
	}
}