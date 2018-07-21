using Navegacion.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Navegacion.Model
{
    public class IncidenciaRepository
    {
        public IList<Incidencia> Incidencias { get; set; }

        public IncidenciaRepository()
        {
            Task.Run(async () =>
            Incidencias = await App.DataBase.GetFriendsAsync()).Wait();
        }
        public IList<Incidencia> GetAll()
        {
            return Incidencias;
        }
        public
            ObservableCollection
            <Grouping<string, Incidencia>>
            GetAllGrouped()
        {
            IEnumerable<Grouping<string, Incidencia>> sorted = new Grouping<string, Incidencia>[0];
            if (Incidencias != null)
            {
                sorted =
                from f in Incidencias
                orderby f.Area
                group f by f.Area == null ? "<null>" : f.Area
                into theGroup
                select
                new Grouping<string, Incidencia>
                (theGroup.Key, theGroup);
            }
            return new
                ObservableCollection
                <Grouping<string, Incidencia>>(sorted);
        }
    }
}
