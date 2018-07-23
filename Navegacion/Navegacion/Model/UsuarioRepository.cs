using Navegacion.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Navegacion.Model
{
    public class UsuarioRepository //SecondRepository
    {
        public IList<Usuario> Usuarios { get; set; }

        public UsuarioRepository()
        {
            Task.Run(async () =>
            Usuarios = await App.DataBases.GetFriendsAsync()).Wait();
        }
        public IList<Usuario> GetAll()
        {
            return Usuarios;
        }
        public
            ObservableCollection
            <Grouping<string, Usuario>>
            GetAllGrouped()
        {
            IEnumerable<Grouping<string, Usuario>> sorted = new Grouping<string, Usuario>[0];
            if (Usuarios != null)
            {
                sorted =
                from f in Usuarios
                orderby f.Area
                group f by f.Area == null ? "<null>" : f.Area
                into theGroup
                select
                new Grouping<string, Usuario>
                (theGroup.Key, theGroup);
            }
            return new
                ObservableCollection
                <Grouping<string, Usuario>>(sorted);
        }
    }
}
