import { Address } from "./address";

export class Client {
    constructor(public id: string, public name: string , public address:Address){
        this.id = id;
        this.name = name;
        this.address = address;
    }
}