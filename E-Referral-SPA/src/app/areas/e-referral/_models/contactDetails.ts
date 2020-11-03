import { City } from '../../cities/city';
import { CommunicationMethodEnum } from './enums/communicationMethodEnum';
import { GpPractice } from '../../gp-practices/gpPractice';

export interface ContactDetails {
    nhsnumber: string;
    gpPractice: GpPractice;
    firstName: string;
    lastName: string;
    birthDay: Date;
    address1: string;
    address2: string;
    city: City;
    anotherCity: string;
    postCode: string;
    phone: string;
    mobile: string;
    email: string;
    MethodsToContact: string;
}
