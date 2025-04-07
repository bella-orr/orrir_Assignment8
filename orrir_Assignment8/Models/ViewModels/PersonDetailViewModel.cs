using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace orrir_Assignment8.Models.ViewModels
{
    partial class PersonDetailViewModel : ObservableObject
    {
        [ObservableProperty]
        private Person person;
    }
}
