# Noel's Bakery

### By Noel Kirkland, 8/14/2020

•[Setup](#2)<br>
•[Bugs](#3)<br>
•[Contact](#4)<br>
•[Tech](#5)<br>
•[License](#6)

## Description

This is an API. 

## Setup/Installation Requirements <a name="2"></a>

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
  3. _Navigate into the **`BakeryId.Solution`** repository and click the green button labeled "Clone or download" and download the zip to your computer_

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
  4. __
```
{
  "username": "YOUR-USERNAME-HERE",
  "password": "YOUR-PASSWORD-HERE"
}
```

## Known Bugs <a name="2"></a>

There are no known bugs at this time

## Support and Contact Details <a name="3"></a>

If there are any issues or questions contact me at noelkirkland@gmail.com

## Technologies Used <a name="4"></a>

*  C#/.NET
*  MySQL
*  HTML
*  CSS
*  Markdown


### License <a name="5"></a>

*This project uses the following license: [MIT](https://opensource.org/licenses/MIT)*