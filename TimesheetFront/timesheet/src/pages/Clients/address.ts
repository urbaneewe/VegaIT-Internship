import { Country } from './country';

export class Address {
    constructor(public id: string, public name: string, public city: string, public postalCode: number, public country: Country){
        this.id = id;
        this.name = name;
        this.city = city;
        this.postalCode = postalCode;
        this.country = country;
    }
}