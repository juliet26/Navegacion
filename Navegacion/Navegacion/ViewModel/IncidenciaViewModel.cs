using Navegacion.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Navegacion.ViewModel
{
    public class IncidenciaViewModel
    {
        public Command SaveCommand { get; set; }
        public Command DeleteCommand { get; set; }
        public bool IsEnabled { get; set; }
        public Incidencia FriendModel { get; set; }
        private INavigation Navigation;

        public IncidenciaViewModel(INavigation navigation)
        {
            FriendModel = new Incidencia();
            SaveCommand = new Command(async () => await SaveFriend());
            Navigation = navigation;
        }
        public IncidenciaViewModel(INavigation navigation, Incidencia friend)
        {
            FriendModel = friend;
            SaveCommand = new Command(async () => await SaveFriend());
            Navigation = navigation;
            IsEnabled = true;
            DeleteCommand = new Command(async () => await DeleteFriend());
        }
        public async Task SaveFriend()
        {
            await App.DataBase.SaveFriendAsync(FriendModel);
            await Navigation.PopToRootAsync();
        }
        public async Task DeleteFriend()
        {
            await App.DataBase.DeleteFriendAsync(FriendModel);
            await Navigation.PopToRootAsync();
        }

    }
}
