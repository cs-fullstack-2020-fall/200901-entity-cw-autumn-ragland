# 20 09 01 Entity Classwork

#### Database Set Up
- create an MCV application called Classwork using the .NET CLI
- add the required Entity Framework packages
- create a student model with properties id, name, and classwork average (out of 5)
- create a student database context 
	- this dbcontext extends the base class DbContext imported from `Microsoft.EntityFrameworkCore`
	- the class constructor extends the base constructor passing options 
	- this class has one property students of type DbSet<ModelToReference>
- update the `appsettings.json` file to include a Connection Strings property
- update the `Startup.cs` file to include reference to created database context and connection string in the `ConfigurationSrevices` method
- add and apply migrations for initial creation

#### CRUD Functionality
- create a student controller
- define one private readonly class property called `_context` and set the value of that property in the class constructor 
- Read All - GET
	- get method to pass students in the database to a view
	- return a view displaying the id and name of each student in the browser
	- if the student's classwork average is 3 or higher display the text "This student is doing well!" as well
- Read One - GET
	- get method to find a student by ID 
	- if a student can not be found by ID return the text "Student Not Found"
	- if a student can be found return a view displaying the id and name of the matching student in the browser
	- if the student's classwork average is 3 or higher display the text "This student is doing well!" as well
- Create - POST
	- post method to add student to the database
	- return a view displaying the id and name of each student in the browser
	- if the student's classwork average is 3 or higher display the text "This student is doing well!" as well
- Update - PUT
	- put method to update the classwork average property of a student by ID
	- if a student can not be found by ID return the text "Student Not Found"
	- if a student can be found return a view displaying the id and name of each student in the browser
	- if the student's classwork average is 3 or higher display the text "This student is doing well!" as well
- Delete - DELETE
	- delete method to delete a gamer from the database by ID
	- if a student can not be found by ID return the text "Student Not Found"
	- if a student can be found return a view displaying the id and name of each student in the browser
	- if the student's classwork average is 3 or higher display the text "This student is doing well!" as well
 