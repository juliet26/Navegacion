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
	public partial class FriendPage : ContentPage
	{
        public FriendPage(Friend friend = null)
        {
            InitializeComponent();
            if (friend == null)
            {
                this.BindingContext = new FriendViewModel(Navigation);
            }
            else
            {
                this.BindingContext = new FriendViewModel(Navigation, friend);
            }
        }
    }
}