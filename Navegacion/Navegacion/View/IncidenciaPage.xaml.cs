using Navegacion.Model;
using Navegacion.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navegacion.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IncidenciaPage : ContentPage
	{
        public IncidenciaPage(Incidencia friend = null)
        {
            InitializeComponent();
            if (friend == null)
            {
                this.BindingContext = new IncidenciaViewModel(Navigation);
            }
            else
            {
                this.BindingContext = new IncidenciaViewModel(Navigation, friend);
            }
        }
    }
}