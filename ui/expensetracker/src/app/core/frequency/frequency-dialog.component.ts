import { Component } from '@angular/core';
import { Frequency } from 'src/app/shared/model/frequency.model';
import { DialogBaseComponent } from 'src/app/shared/component/dialog-base.component';

@Component({
    selector: 'app-frequency-dialog',
    templateUrl: './frequency-dialog.component.html'
})
export class FrequencyDialogComponent implements DialogBaseComponent {
    item = new Frequency();
}
