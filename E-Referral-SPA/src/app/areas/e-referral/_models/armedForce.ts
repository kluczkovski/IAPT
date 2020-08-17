import { BranchEnum } from './enums/branchEnum';

export interface ArmedForce {
    memberOfArmedForce: boolean;
    hasLinkedWithArmedForce: boolean;
    branch: BranchEnum;
    serviceNumber: string;
}
