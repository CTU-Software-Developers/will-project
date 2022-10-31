# will-project

### Installation
After cloning open NuGet console and run below command

```sh
Update-Package Microsoft.CodeDom.Providers.DotNetCompilerPlatform -r
```

### DB Creation
Create a database in any SQL IDE

```sh
CREATE DATABASE willdatabase;
```

Afterwards connect your database to your VS and add the connection string in Web.config

```sh
<connectionStrings>
   <add name="DefaultConnection" connectionString="Data Source=.;Initial Catalog=willdatabase;Integrated Security=True" providerName="System.Data.SqlClient" />
</connectionStrings>
```

Then enter the next command into the NuGet console

```cmd
update-database
```


## Project Description
MCSD – Software Development: Event Management System You are required to design a websites using WFC/MVC technology. The website will perform the following: 

- Give attendees easy access to key event information, live and upcoming sessions, surveys, and more with a dynamic event home screen. -
- Integrated the social marketing and Facebook promotion. -
- Include discount codes and voucher codes for group registration -
- Integrated system for finding guest reviews, to further increase the service delivery. -
- Integrate a database that will record all future events, promotion, discount group and attendees reviews. -

The Seven Phases of the System-Development Life Cycle should be followed in the design of the website: 

1. Planning. This is the first phase in the systems development process.
2. Systems Analysis and Requirements.
3. Systems Design.
4. Development.
5. Integration and Testing.
6. Implementation.
7. Operations and Maintenance