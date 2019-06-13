export class Report {
  public id: number;
  public employeeId: number;
  public managerId: number;
  public reportText: string;
  public issuedDate: Date;

  constructor(id: number, employeeId: number, managerId: number, ReportText: string, issuedDate: Date) {
    this.id = id;
    this.employeeId = employeeId;
    this.managerId = managerId;
    this.reportText = ReportText;
    this.issuedDate = issuedDate;
  }
}
