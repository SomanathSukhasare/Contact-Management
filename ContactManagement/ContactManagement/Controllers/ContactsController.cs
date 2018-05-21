using ContactsDAL.IRepository;
using ContactsDAL.Repositoy;
using DataContracts;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ContactManagement.Controllers
{
    [Authorize]
    public class ContactsController : ApiController
    {
        private IContactRepository _contactRepository;
        public ContactsController()
        {
            _contactRepository = new ContactRepository();
        }        

        /// <summary>
        /// Get all contacts
        /// </summary>
        /// <returns>list of contacts</returns>
        [HttpGet]
        public HttpResponseMessage GetContacts()
        { 
            try
            {
                //Prepare data to be returned using Linq as followsss
                var contacts = _contactRepository.GetAll();

                //return Ok(contacts);
                return Request.CreateResponse(contacts);
            }
            catch (Exception ex)
            {
                //If any exception occurs return with error message
                return Request.CreateResponse(ex.Message);
            }
        }


        /// <summary>
        /// Creating a method to add contact
        /// </summary>
        /// <param name="Contact"></param>
        /// <returns>success/failure</returns>
        [HttpPost]
        public HttpResponseMessage AddContact([FromBody]Contact Contact)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var ContactID = _contactRepository.Insert(Contact);

                    return Request.CreateResponse(ContactID);
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(ex.Message);
                }
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        /// <summary>
        /// Update contact details for User
        /// </summary>
        /// <param name="Contact"></param>
        /// <returns>success/failure</returns>
        [HttpPost]
        public HttpResponseMessage UpdateContact(Contact Contact)
        {
            try
            {
                _contactRepository.Update(Contact);

                return Request.CreateResponse(Contact);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(ex.Message);
            }
        }

        /// <summary>
        /// Delete selected contact of User
        /// </summary>
        /// <param name="ContactID"></param>
        /// <returns>success/failure</returns>
        [HttpPost]
        public HttpResponseMessage DeleteContact(int ContactID)
        {
            try
            {
                var contact = _contactRepository.GetByID(ContactID);
                _contactRepository.Delete(contact);

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(ex.Message);
            }
        }
    }
}