using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Propinas
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void BtnCalcular_OnClicked(Object sender, EventArgs e)
            {
            var total = (decimal.Parse(txtTotal.Text));
            var propina = int.Parse(txtPropina.Text);
            var numPersonas = int.Parse(txtPersonas.Text);
            var totalPropina = (total * propina) / 100;
            lbPropina.Detail = totalPropina.ToString("C");
            lbTotal.Detail = (total + totalPropina).ToString("C");
            lblPropinaPorPersona.Detail = (totalPropina / numPersonas).ToString("C");
            lblTotalPorPersona.Detail =( (totalPropina + total) / numPersonas).ToString("C");

            }
	}
}
