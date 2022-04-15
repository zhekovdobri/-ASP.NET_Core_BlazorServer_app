<img align="justify" alt="chart" width="950px" src="https://github.com/zhekovdobri/-ASP.NET_Core_BlazorServer_app/blob/main/AddIdentity/wwwroot/images/BlazorServer1200px.gif">

# ASP.NET_Core_BlazorServer_app

#### By: Dobri Zhekov

#### C#, HTML and CSS Full-Stack Blazor Server application.

## Technologies Used

<div class=pull-left>

</div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<div class=pull-right>
<img align="right" alt="chart" height="200px" src="https://github.com/zhekovdobri/-ASP.NET_Core_BlazorServer_app/blob/main/AddIdentity/wwwroot/images/Blazor_language_chart.png">
</div>

* _C#_
* _HTML_
* _CSS_
* _Bootstrap_

<br />

## Description
This is a Full-Stack Blazor Server application with "Log in", "Log out" and "Register" sections. It uses Microsoft ASP.NET Core Authorization and Authentication. I built this app using "Scaffolding". Scaffolding is a feature which is coming by default with VS. It is built in VS. After that, I created the " NewScaffolding Item" and the following "Error message game". Then I choosed a name for my  "Data context class"  to have "Identity Framework" access to my Identity Database. Then according to Microsoft docs I installed these three commands. 

* Install-Package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore
* Add-Migration CreateIdentitySchema
* Update-Database

The first command is already installed. We can check this by double clicking over the name of our project. With the execution of the second one VS will create our "Migration folder", where this "Identity Schema" was established. At last I pushed into the console tha last command "update-database" and it created my database. The next step here was to build the "Anti-request forgery (XSRF) token". For this token, I created over my "Identity" folder a new class named "TokenProvider" and added some code from MS docs into it. The purpose of this class is to present this token. 

````
namespace "project name".Areas.Identity
{
    public class TokenProvider                              
    {
        public string XsrfToken { get; set; }       // You can name it AccessToken too.   
        public string RefreshToken { get; set; }   
    }
}
````

Then into the "HOst.cshtml" the root page of my application I created and passed this "token" to the application.

```` @inject Microsoft.AspNetCore.Antiforgery.IAntiforgery Xsrf  
 @{    Layout = null;
    var tokens = new TokenProvider                                                                  
    {
        XsrfToken = Xsrf.GetAndStoreTokens(HttpContext).RequestToken     
    };
}
````
Then I moved to "Import.razor" component to import the "namespace", This is the place where the "TokenProvider is located. After that I modified the "App.razor" code (the root component) in order to pass our token object. 

* Injected the "TokenProvider"
* Added "CascadingAuthenticationState"
* Changed "RouteView" with "AuthorizeRouteView""
* Created the "TokenProvider parameter" with the name "InitialState".

Then into the "c#Start.cs I added:

* "namspace" (the place where the "TokenProvider is located)
* services.AddScoped<TokenProvider>();
* Adding "Authorization" and "Authentication" in the map section.
* Mapping our pages with "endpoints.MapRazorPages();"
  
Next I created "RedirectToLogin.razor" component to redirect the users to the "Log in" page, and "Loging Display" component and add it to the "MainLayout.razor" component whch is the root layout of the component.   

</div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<div class=pull-right>
<img align="right" alt="chart" height="100px" src="https://github.com/zhekovdobri/-ASP.NET_Core_BlazorServer_app/blob/main/AddIdentity/wwwroot/images/Directory_structure_logo.png">
</div>

## Directory structure:

<img alt="chart" src="https://github.com/zhekovdobri/-ASP.NET_Core_BlazorServer_app/blob/main/AddIdentity/wwwroot/images/Blazor_Server_Directory_structure.png">

## Setup/Installation Requirements

### Clone a repository using the command line 

1. From the repository, click "Code" and copy the address (either the SSH format or the HTTPS). 
2. From a terminal window (cmd or Bash), change to the local directory where you want to clone your repository.
3. Paste the address you copied from GitHub, with one of the next comand:

* **Clone over HTTPS**<br>
  $ git clone (https://..)
  
* **Clone over SSH**<br>
  $ git clone (ssh://..)

## Known Bugs

* No bugs

## License

Alexandragloss_Homepage_Fashion project is licensed under the GNU GPL 3 license.

<sub><sup>Copiright © 2016-2021 Dobri Zhekov All Rights Reserved</sup></sub>
