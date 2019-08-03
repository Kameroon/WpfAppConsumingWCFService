using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppConsumingWCFService.ServiceReference2;

namespace WpfAppConsumingWCFService.DataAccessLayer
{
    public class PersonController
    {

        private string BASE_URL = "http://localhost:50191/Service1.svc/";

        private static Person _person;
        private static string _result = null; 

        public List<Person> GetPersons()
        {
            var PersonList = new List<Person>();
            using (var serviClt = new Service1Client())
            {
                PersonList = serviClt.GetPersons().ToList();
                return serviClt.GetPersons().ToList();
            }

            //try
            //{
            //    var serviClt = new Service1Client();
            //    var json = serviClt.DownloadString(BASE_URL + "GetPersons");
            //    var js = new JavaScriptSerializer();
            //    return js.Deserialize<List<Person>>(json);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    throw;
            //}
        }

        public Person GetPersonById(int id)
        {
            _person = new Person();
            var serviClt = new Service1Client();
            _person = serviClt.GetPersonById(id.ToString());
            return _person;
        }

        public string AddPerson(Person persObj)
        {
            if (persObj != null)
            {
                var serviClt = new Service1Client();

                _result = serviClt.InsertPerson(persObj) ? "Insertion réussie." : "Erreur durant insertion !";
            }
            else
                _result = "Assurez-vous d'avoir renseigner tous les champs";
            
            return _result;
        }

        public string UpdPerson(Person persObj)
        {
            if (persObj != null)
            {
                var serviClt = new Service1Client();
                _result = serviClt.UpdatePerson(persObj) ? "Mise à jour réussie." : "Erreur durant la mise à jour !";
            }
            else
                _result = "Assurez-vous d'avoir renseigner tous les champs";

            return _result;
        }

        public void DelPerson(int id)
        {
            if (id == 0) return;

            var serviClt = new Service1Client();
            _result = serviClt.DeletePerson(id.ToString()) ? "Suppression réussie." : "Erreur durant la suppression !";
        }
    }
}
