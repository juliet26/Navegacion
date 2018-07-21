using Navegacion.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Navegacion.Data
{
    public class IncidenciaDataBase
    {
        private readonly SQLiteAsyncConnection database;

        public IncidenciaDataBase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Incidencia>().Wait();
        }

        public async Task<List<Incidencia>> GetFriendsAsync()
        {
            return await database.Table<Incidencia>().ToListAsync();
        }

        public Task<Incidencia> GetFriendsAsync(int id)
        {
            return database.Table<Incidencia>().Where(f => f.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveFriendAsync(Incidencia incidencia)
        {
            if (incidencia.ID != 0)
            {
                return database.UpdateAsync(incidencia);
            }
            else
            {
                return database.InsertAsync(incidencia);
            }
        }

        public Task<int> DeleteFriendAsync(Incidencia incidencia)
        {
            return database.DeleteAsync(incidencia);
        }
    }
}
