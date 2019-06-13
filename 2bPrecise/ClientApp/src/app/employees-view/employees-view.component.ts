import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Employee } from '../shared/models/employee.model';

@Component({
  selector: 'app-employees-view',
  templateUrl: './employees-view.component.html'
})
export class EmployeesViewComponent {
  public employees: Employee[];

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Employee[]>(baseUrl + 'api/employee/').subscribe(result => {
      this.employees = result.map(obj => {
        return new Employee(obj.id, obj.firstName, obj.lastName, obj.position, obj.imgUrl, obj.managerId);
      })
    }, error => console.error(error));
  }
}
