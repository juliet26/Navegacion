
using Navegacion.Helpers;
using Navegacion.Model;
using Navegacion.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Navegacion.ViewModel
{
    class SecondPageViewModel : NotificableIncidencia
    {
        private SecondRepository secondRepository;
        public ObservableCollection
            <Grouping<string, Second>> Seconds
        { get; set; }
        public Command AddFriendCommand { get; set; }
        public Command AddUsuarioCommand { get; set; }
        public Command ItemTappedCommand { get; set; }
        public Command SearchCommand { get; set; }
        private INavigation Navigation;
        private string filter;
        private Second currentFriend;
        public string Filter
        {
            get
            {
                return filter;
            }
            set
            {
                SetValue(ref filter, value);
            }
        }

        public Second CurrentFriend
        {
            get
            {
                return currentFriend;
            }
            set
            {
                SetValue(ref currentFriend, value);
            }
        }

        public SecondPageViewModel(INavigation navigation)
        {
            secondRepository = new SecondRepository();
            Seconds = secondRepository.GetAllGrouped();
            Navigation = navigation;
            AddFriendCommand = new Command(async () => await AddFriend());
            AddUsuarioCommand = new Command(async () => await AddUsuario());
            SearchCommand = new Command(async () => await Search());
            ItemTappedCommand = new Command(async () => await NavigateToEditFriendView());

        }

        private Task Search()
        {
            throw new NotImplementedException();
        }

        private async Task NavigateToEditFriendView()
        {
            await Navigation.PushAsync(new IncidenciaRPage(CurrentFriend));
        }

        public async Task AddFriend()
        {
            await Navigation.PushAsync(new IncidenciaRPage());
        }

        public async Task AddUsuario()
        {
            await Navigation.PushAsync(new MainPage());
        }

    }
}
