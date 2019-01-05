import { HttpClient } from '@angular/common/http';
import { RestService } from '../service/rest.service';
import { map, catchError } from 'rxjs/operators';
import { MatSnackBar } from '@angular/material';
import { of } from 'rxjs/internal/observable/of';
import { Observable } from 'rxjs';

export abstract class CrudBaseComponent<T> {

    items: Observable<T[]>;

    constructor(private http: HttpClient, private service: RestService<T>, private snackBar: MatSnackBar) { }

    create(entity: T) {
        this.service.create(this.basepath(), entity)
            .pipe(catchError((error) => this.hanleError(error)))
            .subscribe();
    }

    search() {
        this.items = this.service.find(this.basepath(), undefined);
    }

    showErrorMessage(message: string): void {
        this.snackBar.open(message, 'Close', {
            duration: 2000,
        });
    }

    private hanleError(error: any): Observable<T> {
        this.showErrorMessage(error.message);
        return of(error as T);
    }

    abstract basepath(): string;
}
