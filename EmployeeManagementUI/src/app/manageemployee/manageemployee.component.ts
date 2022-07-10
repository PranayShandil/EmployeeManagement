import { Component, OnInit } from '@angular/core';
import { EmployeeService } from 'src/app/_services/employee.service';

@Component({
  selector: 'app-manageemployee',
  templateUrl: './manageemployee.component.html',
  styleUrls: ['./manageemployee.component.css']
})
export class ManageemployeeComponent implements OnInit {

  employees: any;
  model: any = {};
  constructor(private employeeService: EmployeeService) {
  } 

  ngOnInit(): void {
    this.getEmployees();
  }

  getEmployees() {
    this.employeeService.getAll().subscribe({
      next: response => this.employees = response
    });
  }

  getEmployee(employee: any) {
    this.employeeService.get(employee.employeeNumber).subscribe({
      next: response => this.model = response
    });
  }

  submitData() {
    this.employeeService.createOrUpdate(this.model).subscribe(() => {
      alert('Employee saved successfully!!');
      this.getEmployees();
    }, error => {
      alert(error.error);
    });
  }

  delete(employee: any) {
    this.employeeService.delete(employee.employeeNumber).subscribe(() => {
      alert('Employee deleted successfully!!');
      this.getEmployees();
    }, error => {
      alert(error.error);
    }
    );
  }
}
