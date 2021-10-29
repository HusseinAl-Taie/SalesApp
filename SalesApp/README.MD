Sales App document

#Why are we doing this?
- This is part of QA training, A C sharp project that communicates with a MySql DB to Write and Read Sales data
from a MySQL DB
- The app if formed of two main Functionalities, CRUD and Reports functionality.
- The CRUD functionality is implememnted in a distributed maner to acheive seperation of
  responsiblity to allow easeir and faster delivery.(not complete)
- The Reports Functionality is implemented by making requests to the Database in the form of specific
   schemas.This functionality(Not Fully developed).



#How I expected the challenge to go. 
- I expected this to be easier that proved to be due to the lack of time and knowledge

#What went well? 
- Learning how C# operates and how it a seperation of responsibilities within the app is done.

#What didn't go as planned? 

- Improve knowledge retention of JS as it will waste a longer time to gain it back to develop the project.
- later recordings of the training were challenging to go through
- Time allocation can be improved

#Possible improvements for future
- Develop the Reports functionality by linking the ready SQL commands to the app.
- Investigate error when reading the data where the fields are mixed.
- Investigate error when writing the data it is not written to the DB.

#Requirements:
-	Upon starting the application, the user must be presented with the following two options at a minimum:
o	Data Entry
o	Reports

-	If the user selects Data Entry, they must be able to add a new sales record to the sales table
    in the database.
-	If the user selects Reports, they must be presented with the following four options at a minimum:
    o	Sales by Year (e.g. List of all sales in the year 2020 printed to the console)
    o	Sales by Month and Year (e.g. List of all sales in January of 2020 printed to the console)
    o	Total Sales by Year (e.g. The total amount of sales for 2021, i.e. the sum of all the sales)
    o	Total Sales by Year and Month (e.g. The total amount of sales for January of 2021)
    -	MySQL queries are required for each of the Reports options, your program will run these against
     the database and retrieve the data to build the relevant report for the end user.
