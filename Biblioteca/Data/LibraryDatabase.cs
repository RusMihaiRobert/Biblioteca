using System;
using System.Collections.Generic;
using System.Text;

using SQLite;
using Biblioteca.Models;
using System.Threading.Tasks;


namespace Biblioteca.Data
{
    public class LibraryDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public LibraryDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Carti>().Wait();
            _database.CreateTableAsync<Autori>().Wait();
            _database.CreateTableAsync<Bibliotecari>().Wait();
            _database.CreateTableAsync<Clienti>().Wait();

        }
        public Task<List<Carti>> GetCartiAsync()
        {
            return _database.Table<Carti>().ToListAsync();
        }
         public Task<List<Autori>> GetAutoriAsync()
        {
            return _database.Table<Autori>().ToListAsync();
        }
        public Task<List<Bibliotecari>> GetBibliotecariAsync()
        {
            return _database.Table<Bibliotecari>().ToListAsync();
        }
        public Task<List<Clienti>> GetClientiAsync()
        {
            return _database.Table<Clienti>().ToListAsync();
        }
        public Task<Carti> GetCartiAsync(int id)
        {
            return _database.Table<Carti>()
            .Where(i => i.ID == id)
            .FirstOrDefaultAsync();
        }
        public Task<Autori> GetAutoriAsync(int id)
        {
            return _database.Table<Autori>()
            .Where(i => i.ID == id)
            .FirstOrDefaultAsync();
        }
        public Task<Bibliotecari> GetBibliotecariAsync(int id)
        {
            return _database.Table<Bibliotecari>()
            .Where(i => i.CNP == id)
            .FirstOrDefaultAsync();
        }
        public Task<Clienti> GetClientiAsync(int id)
        {
            return _database.Table<Clienti>()
            .Where(i => i.CNP == id)
            .FirstOrDefaultAsync();
        }
        public Task<int> SaveCartiAsync(Carti carte)
        {
            if (carte.ID != 0)
            {
                return _database.UpdateAsync(carte);
            }
            else
            {
                return _database.InsertAsync(carte);
            }
        }

       
        public Task<int> SaveAutoriAsync(Autori autor)
        {
            if (autor.ID != 0)
            {
                return _database.UpdateAsync(autor);
            }
            else
            {
                return _database.InsertAsync(autor);
            }
        }
        public Task<int> SaveBibliotecariAsync(Bibliotecari bibliotecar)
        {
            if (bibliotecar.CNP != 0)
            {
                return _database.UpdateAsync(bibliotecar);
            }
            else
            {
                return _database.InsertAsync(bibliotecar);
            }
        }
        public Task<int> SaveClientiAsync(Clienti client)
        {
            if (client.CNP != 0)
            {
                return _database.UpdateAsync(client);
            }
            else
            {
                return _database.InsertAsync(client);
            }
        }
        public Task<int> DeleteCartiAsync(Carti carte)
        {
            return _database.DeleteAsync(carte);
        }
        public Task<int> DeleteAutoriAsync(Autori autor)
        {
            return _database.DeleteAsync(autor);
        }
        public Task<int> DeleteBibliotecariAsync(Bibliotecari bibliotecar)
        {
            return _database.DeleteAsync(bibliotecar);
        }
        public Task<int> DeleteClientiAsync(Clienti client)
        {
            return _database.DeleteAsync(client);
        }
        public Task<List<Carti>> GetListaCartiAsync()
        {
            return _database.QueryAsync<Carti>(
            "select P.ID, P.Nume_carte, P.Categorie from Carti P"); 
        }
        public Task<List<Autori>> GetListaAutoriAsync()
        {
            return _database.QueryAsync<Autori>(
            "select P.ID, P.Nume_autor, P.Prenume_autor from Autori P");

        }
        public Task<List<Bibliotecari>> GetListaBibliotecariAsync()
        {
            return _database.QueryAsync<Bibliotecari>(
            "select P.CNP, P.Nume, P.Carte from Bibliotecari P");

        }
        public Task<List<Clienti>> GetListaClientiAsync()
        {
            return _database.QueryAsync<Clienti>(
            "select P.CNP, P.Carte, P.Data_retur from Clienti P");
        }

    }
}
