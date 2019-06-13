export class Task {
  public id: number;
  public employeeId: number;
  public managerId: number;
  public taskText: string;
  public assignedDate: Date;
  public dueDate: Date;

  constructor(id: number, employeeId: number, managerId: number, taskText: string, assignedDate: Date, dueDate: Date) {
    this.id = id;
    this.employeeId = employeeId;
    this.managerId = managerId;
    this.taskText = taskText;
    this.assignedDate = assignedDate;
    this.dueDate = dueDate;
  }
}
