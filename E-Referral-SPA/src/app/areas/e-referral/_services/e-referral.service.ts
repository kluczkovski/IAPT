import { Injectable } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class EReferralService {


  Form: FormGroup = new FormGroup({
    id: new FormControl(null),
    date: new FormControl(''),

    typeReferral: new FormGroup({
      type: new FormControl('', Validators.required),
      source: new FormControl(''),
      agencyInformation: new FormGroup({
        agency: new FormControl(''),
        contactPerson: new FormControl(''),
        phone: new FormControl(''),
        email: new FormControl('', Validators.email),
        hasClientConsented: new FormControl('true'),
      }),
    }),
    contactDetail: new FormGroup({
      NHSnumber: new FormControl(''),
      gpSurgeryId: new FormControl('', [Validators.required]),
      firstName: new FormControl('', [Validators.required, Validators.minLength(2)]),
      lastName: new FormControl('', [Validators.required, Validators.minLength(2)]),
      dateOfBirth: new FormControl('', Validators.required),
      address1: new FormControl('', Validators.required),
      address2: new FormControl(''),
      cityId : new FormControl('', Validators.required),
      stateCity: new FormControl(''),
      postCode : new FormControl('', Validators.required),
      telephone : new FormControl(''),
      mobile : new FormControl(''),
      email : new FormControl('', Validators.email),
      communicationMethods : new FormControl('', Validators.required),
    }),
    diversityDetail: new FormGroup({
      gender: new FormControl('', Validators.required),
      isgenderAssignedAtBirth: new FormControl('', Validators.required),
      ethnicityId : new FormControl('', Validators.required),
      sexuality: new FormControl('', Validators.required),
      religionId: new FormControl('', Validators.required),
      maritalStatus: new FormControl('', Validators.required),
      parentalStatus: new FormControl('', Validators.required),
      physicalDisability: new FormControl('', Validators.required),
      physicalDisabilityState: new FormControl(''),
      specificSupportNeeds: new FormControl('', Validators.required),
      specificSupportNeedState: new FormControl(''),
    }),
    armedForceDetail: new FormGroup({
      memberOfArmedForce: new FormControl('', Validators.required),
      hasLinkedWithArmedForce: new FormControl(''),
      branch: new FormControl(''),
      serviceNumber: new FormControl('')
    }),
    longTermPhysicalHealth: new FormGroup({
      hasClientLTPH: new FormControl('', Validators.required),
      details: new FormControl(''),
    }),
    riskIndicatorInformation: new FormGroup({
      hasClientLRisk: new FormControl('', Validators.required),
      details: new FormControl(''),
      suicideRisk: new FormControl(''),
      selfHarmRisk: new FormControl('')
    }),
    clinicalReferral: new FormGroup({
      clinicalSupportService: new FormControl('', Validators.required),
      accessedSMBefore: new FormControl('', Validators.required),
      smBeforeWhen: new FormControl('', Validators.required),
      hasMentalHealthDiag: new FormControl('', Validators.required),
      statedMentalHealth: new FormControl(''),
      accessedCurrentlyOtherService: new FormControl(''),
      // accessingService: new FormControl('', Validators.required),
      accessingServiceWorkName: new FormControl(''),
      accessingServiceWorkService: new FormControl(''),
      accessingServiceWorkTel: new FormControl(''),
    })
  });

  constructor() { }
}
