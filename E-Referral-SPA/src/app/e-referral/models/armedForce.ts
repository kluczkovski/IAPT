import { BranchEnum } from './enums/branchEnum';

export interface ArmedForce {
    memberOfArmedForce: boolean;
    hasLinkedWithArmedForce: string;
    branch: BranchEnum;
    serviceNumber: string;
}
