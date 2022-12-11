import { Validators } from "@angular/forms";

export interface FormElement {
    id: string;
    validators: Validators[];
    initialValue: any;
}