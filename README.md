# Local Shops API

### By Noel Kirkland, 8/23/2020

•[Setup](#1)<br>
•[Access](#2)<br>
•[Bugs](#3)<br>
•[Contact](#4)<br>
•[Tech](#5)<br>
•[License](#6)

## Description

This is an API application that allows the user to query local business' in Portland, Oregon. The two types of business' that this particular application tracks are Shops and Restaurants. The business' are organized by Neighborhoods. Each Neighborhood can have many Shops and Restaurants but each Shop and each Restaurant can only belong to one Neighborhood. This application comes with a default database that includes 3 Neighborhoods, 6 Restaurants, and 6 Shops. All these business' can be accessed via an API request to localhost:5000 when the application is running.

## Setup/Installation Requirements <a name="1"></a>

* _Install the .NET framework_
  1. _This program utilizes .NET version 3.1, and requires [this framework to be pre-installed](https://dotnet.microsoft.com/download/dotnet-core/3.1)_

* _Install and configure MySQL_
  1. _This program utilizes MySQL Community Server version 8.0.15 and requires [this to be pre-installed](https://dev.mysql.com/downloads/file/?id=484914). Click the link at the bottom that reads "No thanks, just start my download"_
  2. _Use Legacy Password Encryption and set password to "epicodus"_
  3. _Click "Finish_

* _Install Postman_
  1. _Open [this Postman link](https://www.postman.com/downloads/) and click the orange Download button_

* _Download this application from HitHub_
  1. _Open the following web address in your browser: **`https://github.com/NoelKirkland`**_
  2. _Click on the button labeled_ Repositories
  3. _Navigate into the **`LocalShops.Solution`** repository and click the green button labeled "Clone or download" and download the zip to your computer_

* _Install the MySQL database_
  1. _Open the downloaded application in a text editor ([V.S. Code preferred](https://code.visualstudio.com/))_
  2. _Open a new terminal in your text editor (Ctrl+\` in V.S. Code) and run command `> echo 'export PATH="$PATH:/usr/local/mysql/bin"' >> ~/.zprofile`_
  3. _Enter the command `> source ~/.zprofile` to confirm MsSQL has been installed_

* _Create user and secret_
1. _In the Models folder go to the LocalShopContext.cs file_
2. _On line 19 replace the phrase ["YOUR-USERNAME-HERE"] with a username of your choice and replace the phrase ["YOUR-PASSWORD-HERE"] with a password of your choice_
3. _In the root directory go to the file appsettings.json_
4. _On line 3 replace the phrase ["YOUR-SECRET-HERE"] with a 30 character, alpha-numeric code. It could be anything, it just needs to be 30 characters_

* _Run the application_
  1. _In the terminal, navigate to the project directory by running the command `> cd LocalShops`_
  2. _Now that we are in the LocalShops directory you will run the command `> dotnet ef migrations add Demo`_
  3. _Once your terminal has finished loading you will run the command `> dotnet ef database update`_
  4. _Once you see the Migrations directory pop up you can run the command `> dotnet run`_

* _Use the application_
  1. _Open the Postmam application, open a new tab and type http://localhost:5000/users/authenticate into the "Enter request URL" field_
  2. _In the request-type dropdown menu select POST. Click the Body tab, click the radio button "raw", and select JSON from the data-type dropdown_
  3. _Past the code below into the Body section and press send. p.s. add the username and password you had entered in the LocalShopContext.cs file_
  4. _Copy the Token: value to your keyboard from the return object_
  5. _Go into the Authorization tab into each subsequent API request, in the type drop-down select Bearer Token and paste your bearer token, press send_
```
{
  "username": "YOUR-USERNAME-HERE",
  "password": "YOUR-PASSWORD-HERE"
}
```

## Access information <a name="2"></a>

_HTTP request_<br>
_Note: put http://localhost:5000 before each query_
```
  GET /users
  GET /users/{id}
  POST /users/authenticate
```
```
  GET /api/neighborhoods
  GET /api/neighborhoods/{id}
  POST /api//neighborhoods
  PUT /api/neighborhoods/{id}
  DELETE /api/neighborhoods/{id}
```
```
  GET /api/restaurants
  GET /api/restaurants/{id}
  POST /api//restaurants
  PUT /api/restaurants/{id}
  DELETE /api/restaurants/{id}
```
```
  GET /api/shops
  GET /api/shops/{id}
  POST /api//shops
  PUT /api/shops/{id}
  DELETE /api/shops/{id}
```

Path Parameters
|  Parameter | Type | Default | Required | Description |
| :--- | :--- | :--- | :--- | :--- |
|  id | int | none | false | Returns object with matching Id number |
|||||

_Sample JSON response:_
```
  {
      "restaurantId": 2,
      "neighborhoodId": 2,
      "name": "Bertie Lou's Cafe",
      "type": " American breakfast/lunch",
      "starRating": 3
  }
```

## Known Bugs <a name="3"></a>

There are no known bugs at this time

## Support and Contact Details <a name="4"></a>

If there are any issues or questions contact me at noelkirkland@gmail.com

## Technologies Used <a name="5"></a>

*  C#/.NET
*  JWT Authentication
*  MySQL
*  HTML
*  CSS
*  Markdown


### License <a name="6"></a>

*This project uses the following license: [MIT](https://opensource.org/licenses/MIT)

Intellectual property of Noel R. Kirkland - 2020