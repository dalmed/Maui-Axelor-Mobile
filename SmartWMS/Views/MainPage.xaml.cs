using SmartWMS.ViewModels;

namespace SmartWMS.Views;

public partial class MainPage : ContentPage
{
    private readonly MainPageModel model;

    //int count = 0;

	public MainPage()
	{
        BindingContext = model=new MainPageModel();

        InitializeComponent();
	}

    public MainPageModel Model => model;

    //   private void OnCounterClicked(object sender, EventArgs e)
    //{
    //	count++;

    //	if (count == 1)
    //		CounterBtn.Text = $"Clicked {count} time";
    //	else
    //		CounterBtn.Text = $"Clicked {count} times";

    //	SemanticScreenReader.Announce(CounterBtn.Text);
    //}
}

