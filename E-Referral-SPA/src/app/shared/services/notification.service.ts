import { Injectable } from '@angular/core';
import { MatSnackBar, MatSnackBarConfig, MatSnackBarRef } from '@angular/material/snack-bar';


@Injectable({
  providedIn: 'root'
})

export class NotificationService {

  constructor(public snackBar: MatSnackBar) { }

  success(msg) {
    this.snackBar.open(msg, '', {
      duration: 3000,
      verticalPosition: 'bottom',
      horizontalPosition: 'right',
      panelClass: 'success'
    });
  }

  error(msg) {
    this.snackBar.open(msg, 'close', {
      verticalPosition: 'bottom',
      horizontalPosition: 'right',
      panelClass: 'error'
    });
  }
}
