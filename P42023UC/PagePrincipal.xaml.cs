using P42023UC.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace P42023UC
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PagePrincipal : ContentPage
	{
		public PagePrincipal ()
		{
			InitializeComponent ();
		}

        private void btnprocesar_Clicked(object sender, EventArgs e)
        {
			var emple = new Empleado
			{
				id = 1,
				nombres = txtnombre.Text,
				apellidos = txtapellido.Text,
				foto = null
			};

			// esto es para llamar una seguna pagina y pasarle parametro a una seguna pantalla
			var secondpage = new PageResultado();
			secondpage.BindingContext = emple;  // paso de parametros a la pantalla
			Navigation.PushAsync(secondpage);

			// Estoy sin audio un momento no me habia dado cuenta
        }
    }
}