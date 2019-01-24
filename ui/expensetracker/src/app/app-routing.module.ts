import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FrequencyListComponent } from './core/frequency/frequency-list.component';
import { ExpenseTypeListComponent } from './core/expense-type/expense-type-list.component';
import { IncomeListComponent } from './core/income/income-list.component';
import { ExpenseListComponent } from './core/expense/expense-list.component';

const routes: Routes = [
  { path: 'frequencies', component: FrequencyListComponent },
  { path: 'expensetypes', component: ExpenseTypeListComponent },
  { path: 'expenses', component: ExpenseListComponent },
  { path: 'incomes', component: IncomeListComponent },
];

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forRoot(
      routes,
      { enableTracing: true } // <-- debugging purposes only
    )
  ],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule { }
