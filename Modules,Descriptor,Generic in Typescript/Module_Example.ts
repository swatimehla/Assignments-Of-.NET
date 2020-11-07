import { Person } from './Classes';

var message = "hello typescript";
console.log(message);

class employee {
    public empid: number;
    private empname: string;
    constructor(Id: number, name: string) {
        this.empid = Id;
        this.empname = name;
    }
    public display() {
        return ("EmployeeId :" + this.empid + " " + "Employee Name :" + this.empname);
    }
}
let employee1 = new employee(102,'swati');
employee1.empid = 102;
console.log(employee1.display());

class Admin extends Person {

}
class Manager extends Person {

}

let admin = new Admin('Swati', 'Mehla');
let manager = new Manager('Ram', 'Kumar');

console.log(admin.display());
console.log( manager.display());

 
 