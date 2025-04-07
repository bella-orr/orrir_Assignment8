namespace orrir_Assignment8.Views;

public partial class PersonDetail : ContentPage
{
	public PersonDetail()
	{
        InitializeComponent();
    }

   

    private async void goContactListbutton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}