using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace orrir_Assignment8.Models.ViewModels
{
    partial class PersonListViewModel: ObservableObject
    {
        public Action NavigateToContactList { get; set; }

        [ObservableProperty]
        private ObservableCollection<Person> people = new();

        [ObservableProperty]
        private Person person = new();

        [RelayCommand]
        private void Add()
        {
            People.Add(person);
            Person = new Person();

            NavigateToContactList?.Invoke();
        }

    }
}
