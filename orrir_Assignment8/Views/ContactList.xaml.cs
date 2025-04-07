namespace orrir_Assignment8.Views;
using orrir_Assignment8.Models;
using orrir_Assignment8.Models.ViewModels;
using orrir_Assignment8.Views;
public partial class ContactList : ContentPage
{
	public ContactList()
	{
		InitializeComponent();
	}

    private void Lv_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		var person = e.Item as Person;
		var personViewModel = new PersonDetailViewModel { Person = person };
		var personDetail = new PersonDetail();

		personDetail.BindingContext = personViewModel;
		Navigation.PushAsync(personDetail);          

    }

    private async void goBackbutton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}