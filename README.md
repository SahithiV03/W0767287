# Introduction

Plates  - This project is used to manage the plates. Users can Add, Edit, Delete the Plates from this application.

In visual studio code 2019, we are creating a new project named MVCPlates. 
In the Configure your new project dialog, enter MvcPlates for Project name. And then select create. 

In the create new ASP.NET Core web application, select asp dotnet core web app model-view-controller, in dropdown select asp.net core 5.0 
Select Ctrl+F5 to run the app without the debugger.

There would be diaglogue boxes which would be popping ip need to click yes in order to download the development certificates.

Click on debug where you've to click on start without debugging from the top icons and then clicking on IIS express it will automatically open the browser with the Welcome page. 

You can run using ctrl+F5 to run the app.

We will be adding controller, In the Solution Explorer, In the Solution Explorer, right-click Controllers > Add > Controller and in that controller we are choosing MVC empty controller and thereafter MVCController empty and then add name to the controller as PlateControllers.cs 

In the views we would be adding the views, Adding the view: On the right side of the solution explorer, right click on the view folder and then add a new folder to that folder naming as Plates. Here click on Plates folder in views and the add a new item in that select Razor View Empty and then name as Index.cshtml add modifying the code. 

We would be changing the title and footer from the layoutpage, which is found in Views/Shared/_Layout.cshtml

In the views click on home there we would be adding About us like what actually Plates is the company details and employees and headquaters are added. 

Adding a model class as Right-click the Models folder > Add > Class. Name the file Plates.cs and from above icons click on tools there you will find NuGetPacakeManager and then click on PackageManagerConsole and then run the commands. Running the following commands Install-Package Microsoft.EntityFrameworkCore.Design.

Now we would be Using the scaffolding tool to produce Create, Read, Update, and Delete (CRUD) pages for the Plates model.
In Solution Explorer, right-click the Controllers folder and select Add New Scaffolded Item. In the Add Scaffold dialog, select MVC Controller with views, using Entity Framework and then Add.

Complete the Add MVC Controller with views, using Entity Framework dialog:In the Model class drop down select Plates(MVCPlates.Model), in the Data Class context add as MVCPlates.Data.MVCPlatesContent. Scafffolding registers the datbaseContext. With Scafffolding it creates Controllers/PlateController.cs. Razor view files for Create, Delete, Details, Edit, and Index pages: Views/Plates/*.cshtml. A database context class: Data/MvcPlatesContext.cs

From the Tools menu, select NuGet Package Manager > Package Manager Console. Install the following commands: Add-Migration InitialCreate
Update-Database. Run the app if there is error occurs install few more commands SqlException: Cannot open database "MvcPlateContext-1" requested by the login. The login failed.
