import { Component, OnInit, Input } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { BranchEnum } from '../_models/enums/branchEnum';

@Component({
  selector: 'app-armed-forces-detail',
  templateUrl: './armed-forces-detail.component.html',
  styleUrls: ['./armed-forces-detail.component.scss']
})
export class ArmedForcesDetailComponent implements OnInit {


  @Input() form: FormGroup;
  public branchEnum = BranchEnum;
  public listOfBranch: string[] = null;

  constructor() { }

  ngOnInit(): void {
    // Get Enum from Branch
    this.listOfBranch = Object.keys(this.branchEnum);
  }

}
