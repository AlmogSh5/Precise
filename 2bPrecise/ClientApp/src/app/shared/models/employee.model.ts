export interface IEmpyloyee {
  id: number;
  firstName: string;
  lastName: string;
  position: number;
  imgUrl: string;
  managerId: number;
}

export class Employee {
  public id: number;
  public firstName: string;
  public lastName: string;
  public position: number;
  public imgUrl: string;
  public managerId: number;

  constructor(id: number, firstName: string, lastName: string, position: number, imgUrl: string, managerId: number) {
    this.id = id;
    this.firstName = firstName;
    this.lastName = lastName;
    this.position = position;
    this.imgUrl = imgUrl;
    this.managerId = managerId;
  }

  getPositionText = () => {
    return this.position === 0 ? 'Employee' : 'Manager';
  }
}
