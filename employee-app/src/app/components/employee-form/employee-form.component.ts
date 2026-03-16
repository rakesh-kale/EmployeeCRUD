import { Component } from '@angular/core';
import { EmployeeService } from '../../services/employee.service';
import { FormsModule } from '@angular/forms';

import { CommonModule } from '@angular/common';


@Component({
  selector: 'app-employee-form',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './employee-form.component.html'
})
export class EmployeeFormComponent {

  employee:any={
    name:'',
    department:'',
    salary:0
  }

  constructor(private service:EmployeeService){}

  save()
  {
    this.service.addEmployee(this.employee).subscribe(()=>{
      alert("Employee Added")
    })
  }

}