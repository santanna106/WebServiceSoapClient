
using WebServiceSoapClient.App.ServiceContact;
namespace WebServiceSoapClient.App
{
    class Program
    {
        static void Main(string[] args)
        {

            WebServiceContact s = new WebServiceContact();
            var lista = s.GetAllContacts();
            Contact c = new Contact();
            c.Nome = "Gabriel";
            c.Email = "gabriel.teste@gmail.com";

            s.AddContact(c);

            var lista2 = s.GetAllContacts();

        }
    }
}
