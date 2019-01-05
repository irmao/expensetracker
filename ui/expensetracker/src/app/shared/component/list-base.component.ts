import { HttpClient } from '@angular/common/http';
import { RestService } from '../service/rest.service';
import { catchError } from 'rxjs/operators';
import { MatSnackBar, MatDialog } from '@angular/material';
import { of } from 'rxjs/internal/observable/of';
import { Observable } from 'rxjs';
import { DialogBaseComponent } from './dialog-base.component';
import { BaseModel } from '../model/base.model';

export abstract class ListBaseComponent<T> {

    items: Observable<T[]>;

    constructor(protected http: HttpClient, protected service: RestService<T>, protected snackBar: MatSnackBar) { }

    search() {
        this.items = this.service.find(this.basepath(), undefined);
    }

    showErrorMessage(message: string): void {
        this.snackBar.open(message, 'Close', {
            duration: 2000,
        });
    }

    abstract basepath(): string;
}
