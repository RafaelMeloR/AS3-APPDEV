# AS3-APPDEV
AS3 Application Development

Farmers’ market in Montreal have decided to use a software-based product sales system to track every 
sales and place order for missing items properly. You are asked to make a small desktop application so 
that they can keep track of all of their sales & orders perfectly.

Farmers’ market coordinator has shared you the following dataset:

Product Name Product ID Amount(kg) Price(CAD)/kg
Apple           124567     23       2.10
Orange          345678     20       2.49
Raspberry       125678     25       2.35
Blueberry       456732     29       1.45
Cauliflower     238901     24       2.22

As a continuous developer, you have already developed the front-ends of the application, the ADO based 
local database connection and REST API based remote database connection. Both ADO and REST API based 
database connections are pointing to the same database. As a software developer, you need to develop 
test codes and methods to check whether the database connectivity is perfectly working or not. You 
actually need to deploy the following test methods for your database connection:

1. You need to develop test methods for testing the database insertion properties. The method will 
first try to add the data using ADO connection and will verify whether the data is inserted properly
(you can retrieve the entry from the table using SELECT queries and perform assert operation).
After that, you have to insert another data using REST API in the database. You can perform assert 
testing again for this operation in one of two ways: i. use SELECT queries followed by assert 
operation, ii. Extract the response message code and use assert method to test the response 
message code.

2. You need to develop test methods for testing database update properties. The method will first 
update the table using ADO connection and will verify the updated information using SELECT 
queries followed by assertion testing. After that, you have to update the table with another value. 
But instead of ADO connection, this time you are going to update the table with REST API. After 
update operation, you have to verify the update operation by performing assertion testing on the 
updated data. Like ADO based database connection, for testing the REST API based update 
operation you can use the SELECT query-based assertion test. 

3. You need to develop test methods for DELETE operation, for both ADO based database operation 
and REST API based database operation. For this, like previous steps, you can use SELECT query to
verify the non-existence of the deleted data in the table
