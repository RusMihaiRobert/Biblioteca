using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions;

namespace Biblioteca.Models
{
    public class Clienti
    {
        [PrimaryKey, AutoIncrement]
        public int CNP { get; set; }
        
        public string Nume { get; set; }
       
        public string Prenume { get; set; }
        
        public string Numar_telefon { get; set; }
        // [ForeignKey(typeof(Carti))]
        public string Carte { get; set; }
        public string Data_retur { get; set; }

    }
}
