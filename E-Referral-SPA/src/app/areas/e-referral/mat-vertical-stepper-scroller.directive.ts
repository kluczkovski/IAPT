import { Directive, HostListener, ViewChild } from '@angular/core';
import { MatStepperModule, MatStepper } from '@angular/material/stepper';
import { StepperSelectionEvent } from '@angular/cdk/stepper';

@Directive({
  selector: '[appMatVerticalStepperScroller]',
})
export class MatVerticalStepperScrollerDirective {
  constructor(private stepper: MatStepper) {
  }

  @HostListener('selectionChange', ['$event'])
  selectionChanged(selection: StepperSelectionEvent) {
    const stepId = this.stepper._getStepLabelId(selection.selectedIndex - 1);
    const stepElement = document.getElementById(stepId);
    if (stepElement) {
      setTimeout(() => {
        stepElement.scrollIntoView({block: 'start', inline: 'nearest', behavior: 'smooth' });
      }, 250);
    }
  }
}
