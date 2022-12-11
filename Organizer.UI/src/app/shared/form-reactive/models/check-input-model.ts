import { FormElement } from "./form-element";

export interface CheckInputModel extends FormElement {
    name: string;
    label: string;
    isDisabled: boolean;
    inputClassList: string;
    labelClassList: string;
}
