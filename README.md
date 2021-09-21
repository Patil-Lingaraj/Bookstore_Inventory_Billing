# Bookstore_Invoice
A Billing and Inventory system for a Bookstore


Weekly Progress Sept 21st: (Lingaraj Patil)
* All Team members installed Microsoft Visual Studio with the required packages.
* All team members discussed which version to use and installed Microsoft SQL Server 2014.
* To distribute the entire project work was a little unclear as there are some aspects which we together should decide on.
  So, we jotted down a plan for the next few weeks instead.
* All team members discussed and approved eachother's view on some aspects such as design layout of dashboards, documentations to update with time, name of the app etc.
* Major work was to figure out the database tables. We are including 6 datatables, among which the primary ones are Employee, Customer and Book Genre.
  The other tables we are planning to finalize on are Books Transactions and Transaction Details. All of which we plan on relating to the primary datatables via foreign keys.
* The initial draft of the datatables is as follows,
  
  * Employee – Employee ID (Primary Key), First name, Last name, Email, Username, Password, Contact, Address, Gender, Employee type, Date added  and Added by EmployeeID (composite primary key).
  * Book Genre – Book Genre ID (Primary key) , Book Genre, Description, Date added , Added by EmployeeID (Foreign key)
  * Books- Primary key ,Book name, Book Genre ID – Foreign key , description, date added , added by EmployeeID (foreign Key), rate, quantity.
  * Customer/Dealer details- Customer_ID – Primary key , Type, Name, Email, Contact, Address, Date added, Added by EmployeeID (foreign Key).
  * Transactions – Trans_ID (primary key), Trans_Type, Customer_ID (foreign key), Grand total, Trans_Date, TAX, Discount, Added by EmployeeID (foreign key).
  * Transaction Detail – Detail_Id (primary key), Book Author ID(foreign key), Trans_id (foreign key), rate, quantity, total, customer_ID (foreign key), date added, added by EmployeeID (foreign key).
  

Next Week:
* Create Admin and User intial Dashboards
* Link Database to visual studio
