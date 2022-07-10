EmployeeManagementAPI:
1. Change the database connection string(DefaultConnection field) in appsettings.json file.
2. Run the application.
3. Database along with table and initial entry(seed data) should be created when the API loads. Check database to confirm.
4. Browse the url(https://localhost:<PORT>/api/Employee) to see if the link is wroking fine.
5. This link will be copied to the EmployeeManagementUI project's "baseUrl" in EmployeeService.ts to run UI project.