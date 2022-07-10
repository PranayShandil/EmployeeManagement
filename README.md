# EmployeeManagement
This Project is made in Visual Studio 2022.

EmployeeManagementAPI (.NET Core Web API):

1. Change the database connection string(DefaultConnection field) in appsettings.json file.
2. Run the application.
3. Database along with table and initial entry(seed data) should be created when the API loads. Check database to confirm.
4. Browse the url(https://localhost:<PORT>/api/Employee) to see if the link is working fine.

EmployeeManagementUI (Angular):

1. Navigate to the folder in command line and run "npm install". This will install al the prerequisites for the project.
1. update the baseUrl in employee.service.ts which is copied from API.
2. Run the application(ng serve).



For errors related to CORS:
Add chrome extension to allow cors: toggle ON to allow CORS.
https://chrome.google.com/webstore/detail/allow-cors-access-control/lhobafahddgcelffkeicbaginigeejlf/related
