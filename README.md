#Author
SOMANATH A SUKHASARE
5.9Years Experience in DotNet technologies

# Contact-Management
Assignment to Implement Contact management using WebAPI

Technology used : C#.Net, WebAPI, Entity Framework, LINQ.

Tools Used: Visual Studio 2015. Testing : Postman Client.

Concepts Used:
1. Authentication : Owin Security (OAuth 2.0 Access Token Based Security).
2. Validations : Data Annotations.
3. Architecture : Seperate Layered Structure (Service/API Layer, Data Access Layer, Data Contracts, Unit Tests).
4. Dependency Injection using Abstraction.
5. ORM : Entity Framework (Model First Aproach as run time DB creation needed which is good for demo apps).
6. Unit test methods for API Action methods.
7. Followed coding standards.

WORKFLOW
Run the ContentManagement API service.

Download Postman widget from Google chrome.

Copy and paste the url of service in the postman tool.
use token method to generate the token, follow below steps:

AUTHENTICATION: Generating Access Token using OAuth Security
1. Copy and paste url in tool http://localhost:12957/token
2. Select request type as POST.
3. In Request, Headers tab select application type as json.
4. In request Body tab add key values as given beow :
	grant_type : password
	username   : testUser
	password   : Admin123
5. Hit the Send button, you will get the Access token in response.

Now let us test the methods using Access token

ADD CONTACT : 
1. Add URL : http://localhost:12957/api/Contacts/AddContact
2. Request Type: POST
3. In Authorization, select type as OAuth 2.0.
4. In Headers tab, Add Below keys and values:
	Authorization  :  bearer ZEXLNPErxwtLhgfhgf34Icn1kQD8VDsdZFlTKxIN4t-CyBLeSdqueU3N6J6i1gMG7Hb7e3w
	Content-Type   :  application/json
5. In Body tab, select raw and add below request body
	{
"ContactId": 1,
	 "FirstName": "Somanath",
	 "LastName": "Sukhasare",
 
 	"Email": "som@gmail.com",

 	"PhoneNumber": "9955884466",
 	"Status": true
 }
6. Click on SEND

GET CONTACT:
1. Add URL : http://localhost:12957/api/Contacts/GetContacts
2. Request Type: GET
3. In Authorization, select type as OAuth 2.0.
4. In Headers tab, Add Below keys and values:
	Authorization  :  bearer ZEXLNPErxwtLhgfhgf34Icn1kQD8VDsdZFlTKxIN4t-CyBLeSdqueU3N6J6i1gMG7Hb7e3w
	Content-Type   :  application/json
5. Find the response.

UPDATE CONTACT : 
1. Add URL : http://localhost:12957/api/Contacts/UpdateContact
2. Request Type: POST
3. In Authorization, select type as OAuth 2.0.
4. In Headers tab, Add Below keys and values:
	Authorization  :  bearer ZEXLNPErxwtLhgfhgf34Icn1kQD8VDsdZFlTKxIN4t-CyBLeSdqueU3N6J6i1gMG7Hb7e3w
	Content-Type   :  application/json
5. In Body tab, select raw and add below request body
	{
"ContactId": 1,
	 "FirstName": "Somanath",
	 "LastName": "Sukhasare",
 
 	"Email": "som@yahoo.com",

 	"PhoneNumber": "9955884466",
 	"Status": true
 }
6. Click on SEND


DELETE CONTACT : 
1. Add URL : http://localhost:12957/api/Contacts/DeleteContact?ContactID=1
2. Request Type: POST
3. In Authorization, select type as OAuth 2.0.
4. In Headers tab, Add Below keys and values:
	Authorization  :  bearer ZEXLNPErxwtLhgfhgf34Icn1kQD8VDsdZFlTKxIN4t-CyBLeSdqueU3N6J6i1gMG7Hb7e3w
	Content-Type   :  application/json
5. Click on SEND

