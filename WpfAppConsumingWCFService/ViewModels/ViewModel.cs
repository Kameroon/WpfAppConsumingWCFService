using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppConsumingWCFService.DataAccessLayer;
using WpfAppConsumingWCFService.Repositories.Objects_Generics;
using WpfAppConsumingWCFService.ServiceReference2;

namespace WpfAppConsumingWCFService.ViewModels
{
    class ViewModel
    {
        private readonly PersonController pController = new PersonController();

        public ViewModel()
        {
            #region --  Use Generics class and methods --
            var book = new Book { Id = "1110", Name = "C# Advanced" };

            var numbrers = new GenericsList<int>();
            numbrers.Add(10);

            var books = new GenericsList<Book>();
            books.Add(new Book() { Id = "1111", Name = "Titre n°2"});

            // --  Generic Dictionary --
            var dictionary = new GenericsDictionary<string, Book>();
            dictionary.Add("1102", new Book() { Id = "1111", Name = "Titre n°2" });


            // -- Use Generic value type  --
            var num = new Repositories.Objects_Generics.Nullable<int>();
            Console.WriteLine("As est-elle une valeure ? " + num.HasValue);
            Console.WriteLine("New value = : " + num.HasValue);

            #endregion

            // --  Get All  --
            pController.GetPersons();

            // --    --
            Person person = new Person()
            {
                Id = 4,
                Name = "Chateau",
                Adresse = "Versailles Chantiers"
            };
            string insert = pController.AddPerson(person);

        }


    }
}
