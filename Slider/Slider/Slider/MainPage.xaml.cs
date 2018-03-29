using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Slider
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            slider.Value = 0.5f;

		}
        private void ValueChangedHandler (object sender, ValueChangedEventArgs e)
        {
            lblValue.Text = String.Format("Value is {0:f2}", e.NewValue);
        }

    }
}
