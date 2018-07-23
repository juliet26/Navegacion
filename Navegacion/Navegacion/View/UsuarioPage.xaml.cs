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
	public partial class UsuarioPage : ContentPage
	{
        public UsuarioPage(Usuario friend = null)
        {
            InitializeComponent();
            if (friend == null)
            {
                this.BindingContext = new UsuarioViewModel(Navigation);
            }
            else
            {
                this.BindingContext = new UsuarioViewModel(Navigation, friend);
            }
        }
    }
}