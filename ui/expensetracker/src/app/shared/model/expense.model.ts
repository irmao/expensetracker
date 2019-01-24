import { BaseModel } from './base.model';
import { Frequency } from './frequency.model';
import { ExpenseType } from './expense-type.model';

export class Expense extends BaseModel {
    description: string;
    comment: string;
    frequency: Frequency;
    frequencyId: number;
    value: number;
    expenseType: ExpenseType;
    expenseTypeId: number;
    startDate: Date;
    endDate: Date;
}
