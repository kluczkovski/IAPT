import { ReferralTypeEnum } from './enums/referralTypeEnum';
import { ContactDetails } from './contactDetails';
import { Diversity } from './diversity';
import { AgencyInformation } from './agencyInformation';
import { ArmedForce } from './armedForce';
import { LongTermPhysicalHealth } from './longTermPhysicalHealth';
import { RiskIndicator } from './riskIndicator';
import { ClinicalReferral } from './clinicalReferral';

export interface Ereferral {
    id: string;
    date: Date;
    type: ReferralTypeEnum;
    source: string;
    agencyInformation: AgencyInformation;
    contactDetail: ContactDetails;
    diversityDetail: Diversity;
    armedForce: ArmedForce;
    longTermPhysicalHealth: LongTermPhysicalHealth;
    riskIndicator: RiskIndicator;
    clinicalReferral: ClinicalReferral;
}
