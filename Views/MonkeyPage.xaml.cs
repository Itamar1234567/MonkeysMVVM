using MonkeysMVVM.ViewModels;

namespace MonkeysMVVM;

public partial class MonkeyPage:ContentPage
{
	public MonkeyPage()
	{
		InitializeComponent();
		this.BindingContext = new MonkeyPageViewModel();
	}
}