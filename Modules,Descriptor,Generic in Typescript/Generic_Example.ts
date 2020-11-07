
//Generic Function 
function echo<T>(arg: T): T {
    return arg;
}

var mynumber = echo(100);
var mystring = echo("ABCD");

class Person {
    public Firstname: string;
    public Lastname: string;
    constructor(fname: string, lname: string) {
        this.Firstname = fname;
        this.Lastname = lname;

    }
    display() {
        return this.Firstname + " " + this.Lastname;
    }

}


//Generic Funtion
function PersonEcho<T>(person: T): T {
    return person;
}

let personobj = new Person("Kajal", "Mehla");  //Generic function calling by using Class Person

var foo = PersonEcho(personobj);
console.log(foo.Firstname);
console.log(foo.Lastname);

console.log(PersonEcho("GenericFunction"));//generic Funtion Calling by using value