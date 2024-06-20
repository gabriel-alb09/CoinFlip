namespace CaraOrCoroa
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
        Random rnd = new Random();

            int caraoucoroa = rnd.Next(1, 3);
            int ladoselec = escolha.SelectedIndex;

            if (caraoucoroa == 1)
            {
                if (ladoselec == 0)
                {
                    retorno.Source = "coroa.PNG";
                    retorno2.Text = "SUA ESCOLHA PERDEU! COROA GANHOU ";
                }
                if (ladoselec == 1)
                {
                    retorno.Source = "coroa.PNG";
                    retorno2.Text = "SUA ESCOLHA GANHOU! COROA GANHOU ";
                }
            }
            if (caraoucoroa == 2)
            {
                if (ladoselec == 1)
                {
                    retorno.Source = "cara.PNG";
                    retorno2.Text = "SUA ESCOLHA PERDEU! CARA GANHOU";
                }
                if(ladoselec == 0)
                {
                    retorno.Source = "cara.PNG";
                    retorno2.Text = "SUA ESCOLHA GANHOU!CARA GANHOU";
                }

            }

         

          



        }
    }

}
