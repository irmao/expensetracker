import { HttpClient } from '@angular/common/http';
import { RestService } from '../service/rest.service';
import { MatSnackBar } from '@angular/material';
import { Observable } from 'rxjs';

export abstract class ListBaseComponent<T> {

    items: Observable<T[]>;

    constructor(protected http: HttpClient, protected service: RestService<T>, protected snackBar: MatSnackBar) { }

    search() {
        this.items = this.service.find(undefined, undefined);
    }

    showErrorMessage(message: string): void {
        this.snackBar.open(message, 'Close', {
            duration: 2000,
        });
    }
}
