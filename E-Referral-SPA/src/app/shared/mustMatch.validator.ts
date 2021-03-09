import { FormGroup } from "@angular/forms";


export function MustMatch(controlName: string, matchingControlName: string) {
    return (formGroup: FormGroup) => {
        const control = formGroup.controls[controlName];
        const matchingControl = formGroup.controls[matchingControlName];

        if (matchingControl.errors && !matchingControl.errors.mustmatch)
        {
            // return if another validator has already found an error on the matchingControl   
            return;
        }

        // set error no matchingControl if validation fails
        if (control.value !== matchingControl.value) {
            matchingControl.setErrors({ mustmatch: true});
        } else {
            matchingControl.setErrors(null);
        }
    }
}