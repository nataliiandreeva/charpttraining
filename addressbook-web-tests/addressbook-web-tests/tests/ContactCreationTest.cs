using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {       
        [Test]
        public void ContactCreationTest()
        {
            app.Navigator.GoToCreationNewContactPage();
            ContactData contact = new ContactData("AA");
            contact.Middlename = "2";
            contact.Lastname = "3";
            contact.Nickname = "4";
            contact.Title = "qqq";
            contact.Company = "www";
            contact.Address = "eee";
            contact.Home = "222";
            contact.Mobile = "ddd";
            contact.Work = "sss";
            contact.Fax = "fff";
            contact.Email = "ddd";
            contact.Email2 = "ddd";
            contact.Email3 = "ddd";
            contact.Homepage = "ggg";
            contact.Address2 = "www";
            contact.Phone2 = "ddd";
            contact.Notes = "eee";
            app.Contacts.FillContactDate(contact);
            app.Contacts.SubmitNewContact();
            app.Navigator.ReturnToHomePage();
            app.Auth.Logout();
        }   
    }
}
