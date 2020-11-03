import { Injectable } from '@angular/core';
import { FormGroup, FormControl, Validators, FormArray } from '@angular/forms';
import { format } from 'path';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Ereferral } from '../_models/e-referral';
import { environment } from 'src/environments/environment';
import { catchError } from 'rxjs/operators';
import { Observable, throwError } from 'rxjs';
import { BaseService } from 'src/app/shared/base.service';

@Injectable({
  providedIn: 'root'
})
export class EReferralService extends BaseService {

  url: string = this.baseUrl + '/v1/ereferrals';

  Form: FormGroup = new FormGroup({

    typeReferral: new FormGroup({
      type: new FormControl('', Validators.required),
      source: new FormControl(''),
      agencyInformation: new FormGroup({
        agency: new FormControl(''),
        contactPerson: new FormControl(''),
        phone: new FormControl(''),
        email: new FormControl('', Validators.email),
        agencyHasClientConsent: new FormControl(''),
      }),
    }),
    contactDetail: new FormGroup({
      nhsNumber: new FormControl(''),
      gpPracticeId: new FormControl('', [Validators.required]),
      firstName: new FormControl('', [Validators.required, Validators.minLength(2)]),
      lastName: new FormControl('', [Validators.required, Validators.minLength(2)]),
      birthDay: new FormControl('', Validators.required),
      address1: new FormControl('', Validators.required),
      address2: new FormControl(''),
      cityId : new FormControl('', Validators.required),
      anotherCity: new FormControl(''),
      postCode : new FormControl('', Validators.required),
      phone : new FormControl(''),
      mobile : new FormControl(''),
      email : new FormControl('', Validators.email),
      methodsToContact : new FormControl('', Validators.required),
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
    // armedForceDetail: new FormGroup({
    //   memberOfArmedForce: new FormControl('', Validators.required),
    //   hasLinkedWithArmedForce: new FormControl(''),
    //   branch: new FormControl(''),
    //   serviceNumber: new FormControl('')
    // }),
    // longTermPhysicalHealth: new FormGroup({
    //   hasClientLTPH: new FormControl('', Validators.required),
    //   details: new FormControl(''),
    // }),
    // riskIndicatorInformation: new FormGroup({
    //   hasClientLRisk: new FormControl('', Validators.required),
    //   details: new FormControl(''),
    //   suicideRisk: new FormControl(''),
    //   selfHarmRisk: new FormControl('')
    // }),
    // clinicalReferral: new FormGroup({
    //   clinicalSupportService: new FormControl('', Validators.required),
    //   accessedSMBefore: new FormControl('', Validators.required),
    //   smBeforeWhen: new FormControl('', ),
    //   hasMentalHealthDiag: new FormControl('', Validators.required),
    //   statedMentalHealth: new FormControl(''),
    //   accessedCurrentlyOtherService: new FormControl(''),
    //   listOfServices: new FormArray([]),
    //   accessingServiceWorkName: new FormControl(''),
    //   accessingServiceWorkService: new FormControl(''),
    //   accessingServiceWorkTel: new FormControl(''),
    // }),
    // isvaReferral: new FormGroup({
    //   isvaSupportService: new FormControl('', Validators.required),
    //   currentlyReceivingSupport: new FormControl('', Validators.required),
    //   attendSexualAssaultRefCenter: new FormControl('', Validators.required),
    //   policeInvolved: new FormControl('', Validators.required),
    //   currentOpenInvestigation: new FormControl('', Validators.required),
    //   officerInChargeName: new FormControl(''),
    //   officerInChargeService: new FormControl(''),
    //   officerInChargeTel: new FormControl(''),
    //   victimSupportBeenContact: new FormControl('')
    // }),
    // referralInformation: new FormGroup({
    //   briefSummary: new FormControl('', Validators.required),
    //   whenWasIt: new FormControl('', Validators.required),
    //   offenceType: new FormControl('', Validators.required),
    //   ageAtTimeOfOffence: new FormControl('', Validators.required),
    //   whatWasGenderOfPerpetror: new FormControl('', Validators.required),
    //   whatWasRelationshipToPerpetror: new FormControl('', Validators.required)
    // }),
    // commonSurvivorImpactIndicators : new FormGroup({
    //   hasAnyIssuesWithDrugs: new FormControl('', Validators.required),
    //   hasAnyIssuesWithDrugsDetail: new FormControl(''),
    //   hasOrHadEngagedAnyDrugTreatment: new FormControl('', Validators.required),
    //   listOfTreatments: new FormArray([]),
    //   currentTreatmentName: new FormControl(''),
    //   currentTreatmentService: new FormControl(''),
    //   currentTreatmentTel: new FormControl(''),
    //   precribeAnyMedical: new FormControl('', Validators.required),
    //   precribeAnyMedicalDetails: new FormControl(''),
    //   servedOrCurrentlyUnderInvestiagtion: new FormControl('', Validators.required),
    //   listOfOffences: new FormArray([]),
    //   probationServiceOrCRC: new FormControl('', Validators.required),
    //   listOfProbations: new FormArray([]),
    //   finalComments: new FormControl('')
    // }),
  });

  constructor(private http: HttpClient) {
    super();
  }

  initializeForm() {
    this.Form.reset();
  }

  add(data: Ereferral): Observable<any> {
    return this.http
      .post(this.url, data)
      .pipe(catchError(this.handlerError));
  }

}
