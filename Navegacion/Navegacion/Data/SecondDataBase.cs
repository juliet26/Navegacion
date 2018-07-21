using Navegacion.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Navegacion.Data
{
    public class SecondDataBase
    {
        private readonly SQLiteAsyncConnection database;

        public SecondDataBase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Second>().Wait();
        }

        public async Task<List<Second>> GetFriendsAsync()
        {
            return await database.Table<Second>().ToListAsync();
        }

        public Task<Second> GetFriendsAsync(int id)
        {
            return database.Table<Second>().Where(f => f.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveFriendAsync(Second second)
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

        public Task<int> DeleteFriendAsync(Second second)
        {
            return database.DeleteAsync(second);
        }
    }
}
