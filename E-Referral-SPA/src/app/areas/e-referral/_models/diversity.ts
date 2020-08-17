import { GenderEnum } from './enums/genderEnum';
import { EthnicCategory } from '../../ethnic-categories/ethnicCategory';
import { Religion } from '../../religious-group/religion';
import { MaritalStatusEnum } from './enums/maritalStatusEnum';

export interface Diversity {
    gender: GenderEnum;
    isgenderAssignedAtBirth: string;
    ethnicity: EthnicCategory;
    // sexuality: ;
    religion: Religion;
    physicalDisability: string;
    physicalDisabilityState: string;
    maritalStatus: MaritalStatusEnum;
    parentalStatus: string;
    specificSupportNeeds: boolean;
    specificSupportNeedState: string;
}
