import { EthnicCategory } from '../../ethnic-categories/ethnicCategory';
import { Religion } from '../../religious-group/religion';

export interface Diversity {
    gender: string;
    isgenderAssignedAtBirth: string;
    ethnicity: EthnicCategory;
    sexuality: string;
    religion: Religion;
    maritalStatus: string;
    parentalStatus: string;
    physicalDisability: string;
    physicalDisabilityState: string;
    specificSupportNeeds: string;
    specificSupportNeedState: string;
}
