import { Component, Input } from '@angular/core';

@Component({
    selector: 'app-single-number-card',
    templateUrl: './single-number-card.component.html'
})
export class SingleNumberCardComponent {

    @Input() title: string;
    @Input() subtitle: string;
    @Input() value: number;
}
