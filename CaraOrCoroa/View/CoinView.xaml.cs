using CaraOrCoroa.ViewModel;

namespace CaraOrCoroa.View;

public partial class CoinView : ContentPage
{
	public CoinView()
	{
		InitializeComponent();
		BindingContext = new CoinViewModel();
	}
}