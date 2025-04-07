using orrir_Assignment8.Models.ViewModels;
using orrir_Assignment8.Views;


namespace orrir_Assignment8
{
    public partial class MainPage : ContentPage
    {

        private PersonListViewModel peopleViewModel;
        public MainPage()
        {
            InitializeComponent();

            //Intializes the ViewModel and sets it as the BindingContext for the page
            peopleViewModel = new PersonListViewModel();
            BindingContext = peopleViewModel;

            peopleViewModel.NavigateToContactList = NavigateToContactList;
        }
        private async void NavigateToContactList()
        {
            var contactListPage = new ContactList();
            contactListPage.BindingContext = peopleViewModel;

            // Perform navigation to the ContactList page
            await Navigation.PushAsync(contactListPage);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var contactListPage = new ContactList();
            contactListPage.BindingContext = peopleViewModel;
            await Navigation.PushAsync(contactListPage);
        }
    }

}
