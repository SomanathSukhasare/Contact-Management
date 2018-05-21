using ContactManagement.Controllers;
using DataContracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Web.Http;

namespace ContactManagement.Tests.Controllers
{
    [TestClass]
    public class ContactsControllerTest
    {
        [TestMethod]
        public void GetContactsTest()
        {
            // Arrange
            ContactsController controller = new ContactsController();

            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();


            // Act
            var response = controller.GetContacts();
            
            Assert.AreEqual(response.ReasonPhrase, "OK");
        }
        

        [TestMethod]
        public void AddContactTest()
        {
            // Arrange
            ContactsController controller = new ContactsController();

            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            var Contact = new Contact
            {
                Email = "test@gmail.com",
                FirstName = "ABC",
                LastName = "123",
                PhoneNumber = "6464694664",
                Status = true
            };
            // Act

            var response = controller.AddContact(Contact);

            // Assert
            Assert.AreEqual(response.ReasonPhrase, "OK");
        }

        [TestMethod]
        public void UpdateContactTest()
        {
            ContactsController controller = new ContactsController();

            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            var Contact = new Contact
            {
                Email = "test1@gmail.com",
                FirstName = "ABC",
                LastName = "123",
                PhoneNumber = "6464694664",
                Status = true
            };
            // Act

            var response = controller.UpdateContact(Contact);

            // Assert
            Assert.AreEqual(response.ReasonPhrase, "OK");
        }

        [TestMethod]
        public void DeleteContactTest()
        {
            ContactsController controller = new ContactsController();

            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            // Act
            var response = controller.DeleteContact(1);

            // Assert
            Assert.AreEqual(response.ReasonPhrase, "OK");
        }
    }
}
