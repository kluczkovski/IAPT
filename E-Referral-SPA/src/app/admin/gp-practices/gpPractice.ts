import { CCG } from '../ccgs/Ccg';

export interface GpPractice {
    id: string;
    code: string;
    description: string;
    addressLine1: string;
    addressLine2: string;
    addressLine3?: string;
    addressLine4?: string;
    postCode: string;
    ccgCode: CCG;
}
