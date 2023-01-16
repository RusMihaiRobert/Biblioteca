using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using SQLiteNetExtensions.Attributes;

namespace Biblioteca.Models
{
    public class Autori
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [NotNull, MaxLength(50)]
        public string Nume_autor { get; set; }
       
        [NotNull, MaxLength(50)]
        public string Prenume_autor { get; set; }
        
        //[ForeignKey(typeof(Carti))]
        public string Carte { get; set; }
    }
}
