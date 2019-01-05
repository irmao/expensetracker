import { Component, OnInit } from '@angular/core';
import { Frequency } from 'src/app/shared/model/frequency.model';
import { CrudBaseComponent } from 'src/app/shared/component/crud-base.component';
import { HttpClient } from '@angular/common/http';
import { RestService } from 'src/app/shared/service/rest.service';
import { MatSnackBar } from '@angular/material';

@Component({
  selector: 'app-maintain-frequency',
  templateUrl: './maintain-frequency.component.html',
  styleUrls: ['./maintain-frequency.component.css']
})
export class MaintainFrequencyComponent extends CrudBaseComponent<Frequency> implements OnInit {

  readonly displayedColumns: string[] = ['description', 'averageTimesPerMonth', 'actions'];

  frequency: Frequency;

  constructor(http: HttpClient, service: RestService<Frequency>, snackBar: MatSnackBar) {
    super(http, service, snackBar);
    this.frequency = new Frequency();
  }

  ngOnInit() {
    this.search();
  }

  basepath(): string {
    return 'frequencies';
  }
}
