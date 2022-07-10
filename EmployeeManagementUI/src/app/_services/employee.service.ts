import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  baseUrl = 'https://localhost:44300/api/Employee';
  constructor(private http: HttpClient) { }

  get(model: number) {
    return this.http.get(this.baseUrl + '/GetByCode/' + model);
  }
  getAll() {
    return this.http.get(this.baseUrl);
  }
  createOrUpdate(model: any) {
    return this.http.post(this.baseUrl + '/createorupdate', model);
  }

  delete(employeeNumber: number) {
    return this.http.delete(this.baseUrl + '/Delete/' + employeeNumber);
  }
}
