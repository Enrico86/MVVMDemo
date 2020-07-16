using Foundation.ObjectHydrator;
using MVVMDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;


namespace MVVMDemo.ViewModels
{
    public class PeopleViewViewModel: BaseViewModel
    {
        private Person selectedPerson;

        public ObservableCollection<Person> People { get; set; }

        public Person SelectedPerson
        {
            get => selectedPerson; 
            set
            {
                selectedPerson = value;
                OnPropertyChanged();
            }
        }

        public PeopleViewViewModel()
        {
            Hydrator<Person> _hydratorPeople = new Hydrator<Person>()
                .WithFirstName(n => n.Nombre)
                .WithAmericanPhone(p => p.Telefono)
                .WithEmailAddress(e => e.Email)
                .WithAmericanAddress(a => a.Direccion)
                .WithLastName(ap => ap.Apellido)
                .WithGender(g=>g.Gender);

            People = new ObservableCollection<Person>(_hydratorPeople.GetList(50));
            SelectedPerson = People.Skip(3).FirstOrDefault();
        }
    }
}
