import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Employee } from '../models/employee';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

apiUrl = 'https://localhost:7254/api/Employee'

  constructor(private http:HttpClient) {}

  getEmployees():Observable<Employee[]>
  {
    return this.http.get<Employee[]>(this.apiUrl)
  }

  getEmployee(id:number):Observable<Employee>
  {
    return this.http.get<Employee>(`${this.apiUrl}/${id}`)
  }

  addEmployee(emp:Employee)
  {
    return this.http.post(this.apiUrl,emp)
  }

  updateEmployee(emp:Employee)
  {
    return this.http.put(this.apiUrl,emp)
  }

  deleteEmployee(id:number)
  {
    return this.http.delete(`${this.apiUrl}/${id}`)
  }

}