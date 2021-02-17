import { Offence } from "./offences";
import { OtherServices } from "./otherServices";
import { ProbationService } from "./probationService";

export interface CommonSurvivorImpact {
    hasAnyIssuesWithDrugs: boolean;
    hasAnyIssuesWithDrugsDetail: string;
    hasOrHadEngagedAnyDrugTreatment: string;
    listOfTreatments: OtherServices[];
    currentTreatmentName: string;
    currentTreatmentService: string;
    currentTreatmentTel: string;
    prescribedAnyMedical: string;
    prescribedAnyMedicalDetails: string;
    servedOrCurrentlyUnderInvestigation: boolean;
    listOfOffences: Offence[];
    probationServiceOrCRC: string;
    listOfProbations: ProbationService[];
    finalComments: string;
}
