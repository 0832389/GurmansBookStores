﻿Started at 4:02 PM on 2023/11/27.
Created a new project in .NET5.0 and named it GurmansBookStores and authenticated it for individual accounts.
I got my Area, Controllers and Data folders.
Then, i added README.txt file.
Then, opened the launchSettings.json file and commented the sslport.
Created repository.
Then, i checked my _ViewStart.cshtml file and it is okay.
After that, i checked my all the folders like HomeController.cs, ErrorViewModel.cs, _ViewImport.cshtml and _ViewStart.cshtml.
Did commit to repository.
Then, Put breakpoints on Index and Privacy in HomeController.cs.
Then, tested the application.Due to the breakpoints it did not opened.
Then, continue to issexpress to get the output. At this point i got the Privacy Policy page.
Now, i commited as i am done with part 1.2.
Then, searched for bootstrapwatch and got "Yeti" theme from there which i used for the project.
Then, edited the file name from bootstrap.min.css to bootstrap.css in _Layout.cshtml.
changed nav class from navbar-light to navbar-dark and bg-white to bg-primary.
Edited footer class.
Then, removed text-dark from the line mentioned in the ppt. 
Removed text-dark from _LoginPartial.cshtml file.
Tested the project and it worked as i am able to see the choosen theme.
At 5:01 PM 
added additional stylesheets in_Layout.cshtml file.
Then. added additional scripts to use in the same file.
Now, added dropdown menu.
Check the output. It is okay.
changed the text Dropdown to "content Management".
Now, added 3 Projects mentioned in the ppt (Models,Utility,DataAccess).
installed the 2 packages (Relational and SqlServer).
Then, added the another package. (Identity)
changed the namespace to reflect the project in ApplicationDbContext.cs file.
Deleted Class1.cs files from the 3 projects.
2023-12-05 at 7:19 AM.
Now, added project reference.
Added project references.
Edited the name of models folder to ViewModels.
Changed the namspace of ErrorViewModels.cs to reflect the project.
Build the project. 7:25 AM
Resolved the errors and tested.
In utility project, added SD.cs file and changed the class.
Added project reference to the main project.
Add a 'Customers' area to Areas.
Changed the route in Startup.cs.
Moved HomeControllers.cs to Customer folder.
Edited HomeControllers.cs to define conyrollers is in the Customer Area.
Modified HomeController namespace.
Moved Views>Home.
Copied _ViewImport and _ViewStart to Customer Area.
Modified _ViewStart.cshtml to reflect new path.
Ran the application.
At 12:55 PM added new admin area in Areas.
Deleted Data, Models and Controllers folders.
Updated GitHub Repository.
Finished Part-1.

At 1:06 PM, on 2023/12/07 started Part-2.
Build the project.
Created migrations in after reviewing appsettings.json.
ran the command to add migration (add-migration AddDefaultIdentityMigration).
After reviewing migrations folder, updated the database.
Reviewed the SQL Server Object Explorer.
Added a new table to DB by creating Category.cs file.
Modified Category.cs file.
Ran command add-migration AddCategoryToDb.
Updated database.
Created new folder Repository and IRepository inside it.
Added new item IRepository.cs in IRepository folder.
Modified it following ppt.
updated the ApplicationDbContext.cs file.
updated IRepository.cs.
Added Repository.cs class in Repository folder.
Added code using files for assignment 2.
At 3:36 PM created CategoryRepository.cs and ICategoryRepository.cs classes.
Modified the files.
Reviewed and cleared the errors in both the files. @4:17 PM.
completed the remaining modifications in CategoryRepository.cs.
Installed the NuGet package for Dapper.
Implemented the same thing with new class in Repository folder.
Implemented the ISP_Call interface
Added connection to the database @ 5:02 PM
At 10:43 AM, Dec 08,2023.
Added a new interface UnitOfWork in IRepository and UnitOfWork In Repository.
Did changes as mentioned in ppt.
Build the solution and did commits to guthub,
Now, added CategoryController.cs in Areas/Admin and did changes to use IUnitOfWork.
Added Index.cshtml view to Category folder created in Areas/Views.
Added code using the files provided.
Now, _Layout.cshtml, moved the category link to Content Management Dropdown.
Pushed to github.
Added IAction result to controller and added view.
Added code to Upsert.cshtml from given file.
Added partial view to the general Views/Shared.
created _CreateAndBackToListButton and did coding in it.
Created another partial view _EditAndBackToListButton and added additional code.
Now, at 11:51 AM, modified the Upsert.cshtml file to add partial views.
Added asp-action to index.cshtml file.
Create Upsert post action method in CategoryController.cs.
Moved the _unitOfWork.save() method with return RedirectToaction method . categorycontroller.cs file.
Added API call for HTTPDelete in the same file.
Now, Added delete functionality in category.js.
Added default url function code to category.js.
Finished Part 2.
Did commit.


