import { Component,OnInit } from '@angular/core';
import { EmployeeService } from '../../services/employee.service';
import { Employee } from '../../models/employee';

import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-employee-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './employee-list.component.html',
  styleUrl: './employee-list.component.css'
})
export class EmployeeListComponent implements OnInit {

  employees:Employee[]=[]

  constructor(private service:EmployeeService){}

  ngOnInit()
  {
    this.getEmployees()
  }

  getEmployees()
  {
    this.service.getEmployees().subscribe(res=>{
    console.log(res)
    this.employees = res
  })
  }

  delete(id:number)
  {
    this.service.deleteEmployee(id).subscribe(()=>{
      this.getEmployees()
    })
  }

}