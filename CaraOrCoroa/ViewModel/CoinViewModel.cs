
using CaraOrCoroa.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CaraOrCoroa.ViewModel
{
    internal partial class CoinViewModel : ObservableObject
    {
        [ObservableProperty]
        public String _ladoEscolhido;
        [ObservableProperty]
        public String _resultado;
        [ObservableProperty]
        public String _Imagem;

        public ICommand FlipCommand { get; private set; }

        public CoinViewModel()
        {
            FlipCommand = new Command(Flip);
        }
        public void Flip()
        {
            Coin coin = new Coin();
            Resultado = coin.Jogar(LadoEscolhido);
            Imagem = $"{coin.Lado}.png";
           
        }
    }
}

