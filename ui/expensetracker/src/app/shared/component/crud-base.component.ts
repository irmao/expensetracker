import { HttpClient } from '@angular/common/http';
import { RestService } from '../service/rest.service';
import { catchError, map } from 'rxjs/operators';
import { MatSnackBar, MatDialog } from '@angular/material';
import { of } from 'rxjs/internal/observable/of';
import { Observable } from 'rxjs';
import { DialogBaseComponent } from './dialog-base.component';
import { BaseModel } from '../model/base.model';
import { ListBaseComponent } from './list-base.component';
import { ConfirmDialogComponent } from './confirm-dialog/confirm-dialog.component';

export abstract class CrudBaseComponent<T extends BaseModel> extends ListBaseComponent<T> {

    items: Observable<T[]>;

    constructor(http: HttpClient, service: RestService<T>, snackBar: MatSnackBar, private dialog: MatDialog) {
        super(http, service, snackBar);
    }

    create(entity: T) {
        this.service.create(entity)
            .pipe(
                map(() => this.search()),
                catchError((error) => this.hanleError(error)))
            .subscribe();
    }

    edit(id: number, entity: T) {
        this.service.edit(id, entity)
            .pipe(
                map(() => this.search()),
                catchError((error) => this.hanleError(error)))
            .subscribe();
    }

    delete(id: number) {
        this.service.delete(id)
            .pipe(
                map(() => this.search()),
                catchError((error) => this.hanleError(error)))
            .subscribe();
    }

    openSaveDialog(itemToEdit: T | undefined) {
        const dialogRef = this.dialog.open(this.dialogComponent());

        if (itemToEdit && itemToEdit.id) {
            const componentInstance = dialogRef.componentInstance as DialogBaseComponent;
            componentInstance.item = { ...(itemToEdit as BaseModel) };
        }

        dialogRef.afterClosed().subscribe((result: T) => {
            if (result) {
                if (result.id) {
                    this.edit(result.id, result);
                } else {
                    this.create(result);
                }
            }
        });
    }

    openDeleteDialog(id: number) {
        const dialogRef = this.dialog.open(ConfirmDialogComponent);

        dialogRef.afterClosed().subscribe((result) => {
            if (result) {
                this.delete(id);
            }
        });
    }

    private hanleError(error: any): Observable<T> {
        this.showErrorMessage(error.message);
        return of(error as T);
    }

    abstract dialogComponent();
}
