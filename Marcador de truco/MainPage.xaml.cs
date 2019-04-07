using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MarcadorTruco
{
    

    public partial class MainPage : ContentPage
    {
        
        private int pontosJogador1, pontosJogador2;


        public MainPage()
        {
            InitializeComponent();
        }

        private void OnComputarPontoJ1(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoDoBotaoClicado = botaoClicado.Text;
            int pontos = int.Parse(textoDoBotaoClicado);
            pontosJogador1 += pontos;
            Jogador1label.Text = pontosJogador1.ToString();

            if (pontosJogador1 == 11)
            {
                DisplayAlert("Mão de 11!", $"Podemos ver a mão um do outro!!", "OK");
            }

            if (pontosJogador1 >= 12)
            {
                DisplayAlert("Fim de Jogo", $"Nós ganhamos de {pontosJogador1} x {pontosJogador2}", "SAIR");
                OnNovoJogo(this, null);
            }
        }

        private void OnComputarPontoJ2(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoDoBotaoClicado = botaoClicado.Text;
            int pontos = int.Parse(textoDoBotaoClicado);
            pontosJogador2 += pontos;
            Jogador2label.Text = pontosJogador2.ToString();
            
            if (pontosJogador2 == 11)
            {
                DisplayAlert("Mão de 11!", $"Cuidado! Eles podem ver a mão um do outro!", "OK");
            }


            if (pontosJogador2 >= 12)
            {
                DisplayAlert("Fim de Jogo", $"Eles ganharam de {pontosJogador2} x {pontosJogador1}", "SAIR");
                OnNovoJogo(this, null);
            }
        }

        private void OnTirarPontoJ1(object sender, EventArgs e)
        {
            pontosJogador1 = pontosJogador1 - 1;
            Jogador1label.Text = pontosJogador1.ToString();

            if (pontosJogador1 < 0)
            {
                DisplayAlert("Atenção!", "Valor não pode ser negativo!", "OK");
                pontosJogador1 = 0;
                Jogador1label.Text = pontosJogador1.ToString();
            }
        }

        private void OnTirarPontoJ2(object sender, EventArgs e)
        {
            pontosJogador2 = pontosJogador2 - 1;
            Jogador2label.Text = pontosJogador2.ToString();
            if (pontosJogador2 <= 0)
            {
                DisplayAlert("Atenção!", "Valor não pode ser negativo!", "OK");
                pontosJogador2 = 0;
                Jogador2label.Text = pontosJogador2.ToString();
            }
        }

        private void OnNovoJogo(object sender, EventArgs e)
        {
            pontosJogador1 = 0;
            Jogador1label.Text = pontosJogador1.ToString();
            pontosJogador2 = 0;
            Jogador2label.Text = "0";
        }
    }
}
