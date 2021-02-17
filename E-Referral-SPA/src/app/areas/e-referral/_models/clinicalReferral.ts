import { OtherServices } from './otherServices';

export interface ClinicalReferral {
    clinicalSupportService: boolean;
    accessedSMBefore: boolean;
    SMBeforeWhen: string;
    hasMentalHealthDiag: boolean;
    statedMentalHealth: string;
    accessedCurrentlyOtherService: boolean;
    listOfServices: OtherServices[];
    accessingService: boolean;
    accessingServiceWorkName: string;
    accessingServiceWorkService: string;
    accessingServiceWorkTel: string;
}
