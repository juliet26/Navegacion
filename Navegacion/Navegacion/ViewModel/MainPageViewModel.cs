using Navegacion.Helpers;
using Navegacion.Model;
using Navegacion.View;
using Navegacion.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Navegacion.ViewModel
{
    class MainPageViewModel : NotificableIncidencia
    {
        private IncidenciaRepository incidenciaRepository;
        public ObservableCollection
            <Grouping<string, Incidencia>> Incidencias
        { get; set; }
        public Command AddFriendCommand { get; set; }
        public Command ItemTappedCommand { get; set; }
        public Command SearchCommand { get; set; }
        private INavigation Navigation;
        private string filter;
        private Incidencia currentFriend;
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

        public Incidencia CurrentFriend
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

        public MainPageViewModel(INavigation navigation)
        {
            incidenciaRepository = new IncidenciaRepository();
            Incidencias = incidenciaRepository.GetAllGrouped();
            Navigation = navigation;
            AddFriendCommand = new Command(async () => await AddFriend());
            SearchCommand = new Command(async () => await Search());
            ItemTappedCommand = new Command(async () => await NavigateToEditFriendView());

        }

        private Task Search()
        {
            throw new NotImplementedException();
        }

        private async Task NavigateToEditFriendView()
        {
            await Navigation.PushAsync(new IncidenciaPage(CurrentFriend));
        }

        public async Task AddFriend()
        {
            await Navigation.PushAsync(new IncidenciaPage());
        }

    }

}
