using Navegacion.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Navegacion.Model
{
    public class SecondRepository
    {
        public IList<Second> Seconds { get; set; }

        public SecondRepository()
        {
            Task.Run(async () =>
            Seconds = await App.DataBases.GetFriendsAsync()).Wait();
        }
        public IList<Second> GetAll()
        {
            return Seconds;
        }
        public
            ObservableCollection
            <Grouping<string, Second>>
            GetAllGrouped()
        {
            IEnumerable<Grouping<string, Second>> sorted = new Grouping<string, Second>[0];
            if (Seconds != null)
            {
                sorted =
                from f in Seconds
                orderby f.Area
                group f by f.Area == null ? "<null>" : f.Area
                into theGroup
                select
                new Grouping<string, Second>
                (theGroup.Key, theGroup);
            }
            return new
                ObservableCollection
                <Grouping<string, Second>>(sorted);
        }
    }
}
