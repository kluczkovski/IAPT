import { EthnicCategory } from '../../admin/models/ethnicCategory';
import { Religion } from '../../admin/models/religion';

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
