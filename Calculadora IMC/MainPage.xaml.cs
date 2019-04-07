using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraIMC2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCalcular(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomeEntry.Text))
            {
                DisplayAlert("Erro", "Precisa digitar um nome", "OK");
                return;
            }

            if (string.IsNullOrEmpty(pesoEntry.Text))
            {
                DisplayAlert("Erro", "Precisa digitar um peso", "OK");
                return;
            }

            if (string.IsNullOrEmpty(alturaEntry.Text))
            {
                DisplayAlert("Erro", "Precisa digitar uma altura", "OK");
                return;
            }

            string nome = nomeEntry.Text;
            double peso = Convert.ToDouble(pesoEntry.Text);
            double altura = Convert.ToDouble(alturaEntry.Text);

            // Título, Mensagem e options
            double imc = ((peso * 100) / (altura * altura)) * 100;

            

            if (imc < 18.5)
            {
                DisplayAlert("Resultado", $"O {nome} tem {peso}kg e {altura}m, resultando em um IMC de: {imc:00.00} \n\nVocê está abaixo do peso!", "SAIR");
                return;
            }

            else if (imc < 25)
            {
                DisplayAlert("Resultado", $"O {nome} tem {peso}kg e {altura}m, resultando em um IMC de: {imc:00.00} \n\nVocê está com o peso normal!", "SAIR");
                return;
            }

            else if (imc < 30)
            {
                DisplayAlert("Resultado", $"O {nome} tem {peso}kg e {altura}m, resultando em um IMC de: {imc:00.00} \n\nVocê está acima peso!", "SAIR");
                return;
            }

            else if (imc < 35)
            {
                DisplayAlert("Resultado", $"O {nome} tem {peso}kg e {altura}m, resultando em um IMC de: {imc:00.00} \n\nVocê está com obesidade I!", "SAIR");
                return;
            }

            else if (imc > 35.01)
            {
                DisplayAlert("Resultado", $"O {nome} tem {peso}kg e {altura}m, resultando em um IMC de: {imc:00.00} \n\nVocê está com obesidade II!", "SAIR");
                return;
            }
        }
    }
}
