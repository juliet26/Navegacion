using Navegacion.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Navegacion.Data
{
    public class UsuarioDataBase
    {
        private readonly SQLiteAsyncConnection database;

        public UsuarioDataBase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Usuario>().Wait();
        }

        public async Task<List<Usuario>> GetFriendsAsync()
        {
            return await database.Table<Usuario>().ToListAsync();
        }

        public Task<Usuario> GetFriendsAsync(int id)
        {
            return database.Table<Usuario>().Where(f => f.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveFriendAsync(Usuario second)
        {
            if (second.ID != 0)
            {
                return database.UpdateAsync(second);
            }
            else
            {
                return database.InsertAsync(second);
            }
        }

        public Task<int> DeleteFriendAsync(Usuario second)
        {
            return database.DeleteAsync(second);
        }
    }
}
