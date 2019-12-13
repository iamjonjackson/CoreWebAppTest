# CoreWebAppTest

This project aims to demostrate how to setup a Razor Pages project with a custom scaffolded class, then introducing Identity and customising Identity so that custom fields can be added to the AspNetUsers table while keeping everything in the same dbContext.

Please review the full commit history for more detail.

Project is configured to use Sqlite.

## Steps taken:

1. Created a new project
2. Added a new Student.cs class in /Models
3. Scaffolded the Student class along with database migration and tested it worked by running project and adding a new student via the UI
4. Added necessary CodeGeneration and Identity.UI packages etc...
5. Scaffolded in the full Identity UI pages (Note: it would have actually been better to wait until the end to do this)
5. Tidied up dbContext setup (consolidated into one in a single location and updated any relevant references)
6. Created Identity migration and updated database to create the tables (again, to test it all worked)
7. Added new ApplicationUser.cs class in /Models which extends IdentityUser.
8. Generated migration for the ApplicationUser.cs model
9. Updated database and verified the new field from ApplicationUser.cs appeared in the AspNetUsers table (it does!)

## Next steps:

* you can scaffold in the full Identity pages using this command (or similar): dotnet aspnet-codegenerator identity -dc dbContext -sqlite (make sure you specify the correct database context you're using in your project)
* you can now add as many extra attributes to the underlying Identity user class by using the extended ApplicationUser.cs class. You can also link other entities to users as the ApplicationUser class (and Identity) is all in the same database context
* you will need to customise your Identity scaffolded pages if you want your users to be able to edit their extra field data
