using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ParcialP1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private Entry GetCantidad()
        {
            return Cantidad;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble (Cantidad.Text);

            double dol = n1 * 7.50;


            DisplayAlert("Resultado", dol.ToString(), "total");
        }
    }
}



