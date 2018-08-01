using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestDemo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

        //async void OnButtonClicked(object sender, EventArgs e) 
        //{ 
        //    var nextPage = new Nextpage(); 
        //    await Navigation.PushAsync(nextPage);
        //}

        private async void BtnJson_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JsonParsingPage());
        }

        private async void BtnXml_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new XmlParsingPage());
        }
    }
}