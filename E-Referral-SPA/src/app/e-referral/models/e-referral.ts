import { ReferralTypeEnum } from './enums/referralTypeEnum';
import { ContactDetails } from './contactDetails';
import { Diversity } from './diversity';
import { AgencyInformation } from './agencyInformation';
import { ArmedForce } from './armedForce';
import { LongTermPhysicalHealth } from './longTermPhysicalHealth';
import { RiskIndicator } from './riskIndicator';
import { ClinicalReferral } from './clinicalReferral';
import { IsvaReferral } from './isvaReferral';
import { ReferralInformation } from './referralInformation';
import { CommonSurvivorImpact } from './commonSurvivorImpact';

export interface Ereferral {
    type: ReferralTypeEnum;
    source: string;
    agencyInformation: AgencyInformation;
    contactDetail: ContactDetails;
    diversityDetail: Diversity;
    armedForceDetail: ArmedForce;
    longTermPhysicalHealth: LongTermPhysicalHealth;
    riskIndicator: RiskIndicator;
    clinicalReferral: ClinicalReferral;
    isvaReferral: IsvaReferral;
    referralInformation: ReferralInformation;
    commonSurvivorImpact: CommonSurvivorImpact;
}
