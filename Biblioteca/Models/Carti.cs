using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Biblioteca.Models
{
    public class Carti
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull, MaxLength(120)]
        public string Nume_carte { get; set; }
        [NotNull, MaxLength(50)]
        public string Nume_autor { get; set; }
        [NotNull, MaxLength(50)]
        public string Prenume_autor { get; set; }
        public string Pagini { get; set; }
       
        public string Categorie { get; set; }

    }
}
