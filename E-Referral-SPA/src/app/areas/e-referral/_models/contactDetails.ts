import { City } from '../../cities/city';
import { CommunicationMethodEnum } from './enums/communicationMethodEnum';
import { GpPractice } from '../../gp-practices/gpPractice';

export interface ContactDetails {
    NHSnumber: string;
    gpSurgery: GpPractice;
    firstName: string;
    lastName: string;
    dateOfBirth: Date;
    address1: string;
    address2: string;
    address3: string;
    address4: string;
    city: City;
    postCode: string;
    telephone: string;
    mobile: string;
    email: string;
    communicationMethods: CommunicationMethodEnum;
}
