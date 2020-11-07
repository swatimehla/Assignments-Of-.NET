import { resolveTxt } from "dns";

export class Person {
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