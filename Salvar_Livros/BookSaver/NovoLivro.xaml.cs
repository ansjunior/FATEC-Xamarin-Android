using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookSaver
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NovoLivro : ContentPage
	{
		public NovoLivro ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Livro livro = new Livro()
            {
                Nome = livroEntry.Text,
                Autor = autorEntry.Text

            };

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            { 
            conn.CreateTable<Livro>();
            var numeroDeLinhas = conn.Insert(livro);

                if(numeroDeLinhas > 0)
                    DisplayAlert("FEITO", "Livro e autor salvo!", "Ok");
                else
                    DisplayAlert("Erro", "Livro não foi inserido!", "Ok");
            }


        }
    }
}