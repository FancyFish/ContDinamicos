using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ContDinamicos
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            BtnGenerar.Clicked += BtnGenerar_Clicked;
		}

        private void BtnGenerar_Clicked(object sender, EventArgs e)
        {
            Panel.Children.Add(new Button()
            {
                Text = $"boton{Panel.Children.Count + 1}"
            });
        }
    }
}
