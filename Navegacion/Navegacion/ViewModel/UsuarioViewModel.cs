using Navegacion.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Navegacion.ViewModel
{
    public class UsuarioViewModel
    {
        public Command SaveCommand { get; set; }
        public Command DeleteCommand { get; set; }
        public bool IsEnabled { get; set; }
        public Usuario FriendModel { get; set; }
        private INavigation Navigation;

        public UsuarioViewModel(INavigation navigation)
        {
            FriendModel = new Usuario();
            SaveCommand = new Command(async () => await SaveFriend());
            Navigation = navigation;
        }
        public UsuarioViewModel(INavigation navigation, Usuario friend)
        {
            FriendModel = friend;
            SaveCommand = new Command(async () => await SaveFriend());
            Navigation = navigation;
            IsEnabled = true;
            DeleteCommand = new Command(async () => await DeleteFriend());
        }
        public async Task SaveFriend()
        {
            await App.DataBases.SaveFriendAsync(FriendModel);
            await Navigation.PopToRootAsync();
        }
        public async Task DeleteFriend()
        {
            await App.DataBases.DeleteFriendAsync(FriendModel);
            await Navigation.PopToRootAsync();
        }
    }

}