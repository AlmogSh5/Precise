import { Component, OnInit, Inject } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Employee } from '../shared/models/employee.model';
import { HttpClient } from '@angular/common/http';
import { Report } from '../shared/models/report.model';

@Component({
  selector: 'app-employee-details-component',
  templateUrl: './employee-details.component.html',
  styleUrls: ['./employee-details.component.css']
})
export class EmployeeDetailsComponent implements OnInit {
  public employee: Employee;
  public manager: Employee;
  public reports: Report[];

  constructor(private route: ActivatedRoute, private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {

  }

  async ngOnInit() {
    const id = this.route.snapshot.paramMap.get('id');
    this.http.get<Employee>(this.baseUrl + `api/employee/${id}`).subscribe(result => {
      this.employee = new Employee(result.id, result.firstName, result.lastName, result.position, result.imgUrl, result.managerId);

      this.http.get<Employee>(this.baseUrl + `api/employee/${this.employee.managerId}`).subscribe(result => {
        this.manager = new Employee(result.id, result.firstName, result.lastName, result.position, result.imgUrl, result.managerId);
      },
        error => console.error(error));

      this.http.get<Report[]>(this.baseUrl + `api/employee/${id}/report`).subscribe(results => {
        this.reports = results.map(report => new Report(report.id, report.employeeId, report.managerId, report.reportText, report.issuedDate))
      },
        error => console.error(error));
    },
      error => console.error(error));
  }
}
