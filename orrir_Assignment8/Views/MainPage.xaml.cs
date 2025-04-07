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
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var personList = new ContactList();
            personList.BindingContext = peopleViewModel;
            Navigation.PushAsync(personList);
        }
    }

}
