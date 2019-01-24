import { BaseModel } from './base.model';

export class Frequency extends BaseModel {
    description: string;
    averageTimesPerMonth: number;

    endpoint = 'frequencies';
}
