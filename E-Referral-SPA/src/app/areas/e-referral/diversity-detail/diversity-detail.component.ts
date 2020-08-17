import { Component, OnInit, Input, OnChanges } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { GenderEnum } from '../_models/enums/genderEnum';
import { EthnicCategoryService } from '../../ethnic-categories/ethnic-category.service';
import { EthnicCategory } from '../../ethnic-categories/ethnicCategory';
import { ReligionService } from '../../religious-group/religion.service';
import { Religion } from '../../religious-group/religion';
import { MaritalStatusEnum } from '../_models/enums/maritalStatusEnum';
import { YesNoDeclinedEnum } from '../_models/enums/yesNoDeclinedEnum';

@Component({
  selector: 'app-diversity-detail',
  templateUrl: './diversity-detail.component.html',
  styleUrls: ['./diversity-detail.component.scss']
})
export class DiversityDetailComponent implements OnInit, OnChanges {

  @Input() form: FormGroup;

  public genderEnum = GenderEnum;
  public listOfGender: string[] = null;
  public listOfYesNoDeclined: string[] = null;
  public listOfEthnic: EthnicCategory[] = null;
  public listOfReligion: Religion[] = null;
  public isDisability = false;
  public hasNeeds = false;
  public maritalStatusEnum = MaritalStatusEnum;
  public listOfMaritalStatus: string[] = null;

  constructor(private ethinicService: EthnicCategoryService,
              private religionService: ReligionService) { }

  ngOnInit(): void {
    // Get Enums values
    this.listOfGender = Object.keys(this.genderEnum);
    this.listOfMaritalStatus = Object.keys(this.maritalStatusEnum);

    // Get all Ethnics
    this.getAllEthincs();
    // Get all Religion
    this.getAllReligions();
  }


  ngOnChanges(): void {
    // physical disability
    this.form.get('diversityDetail.physicalDisability').valueChanges.subscribe( (val) => {
          this.isDisability = false;
          if (val === 'Yes') {
              this.isDisability = true;
          } else {
            this.form.patchValue({
              diversityDetail: {
                physicalDisabilityState: ''
              }
            });
          }
      });

    this.form.get('diversityDetail.specificSupportNeeds').valueChanges.subscribe( (val) => {
      this.hasNeeds = false;
      if (val === 'Yes') {
        this.hasNeeds = true;
      }
    });
  }


  private getAllEthincs() {
    return this.ethinicService
      .getAllEthnicCategories()
      .subscribe( result => this.listOfEthnic = result);
  }

  private getAllReligions() {
    return this.religionService
      .getAllReligousGroup()
      .subscribe( result => this.listOfReligion = result);
  }
}
