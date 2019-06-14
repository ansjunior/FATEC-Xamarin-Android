using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSaver
{
    class Livro
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Autor { get; set; }
    }
}
