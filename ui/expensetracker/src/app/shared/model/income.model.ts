import { BaseModel } from './base.model';
import { Frequency } from './frequency.model';

export class Income extends BaseModel {
    description: string;
    frequency: Frequency;
    frequencyId: number;
    value: number;
    startDate: Date;
    endDate: Date;
}
