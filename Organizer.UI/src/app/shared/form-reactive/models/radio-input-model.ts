import { FormElement } from "./form-element";

export interface RadioInputModel extends FormElement {
    name: string;
    label: string;
    isDisabled: boolean;
    inputClassList: string;
    labelClassList: string;
}
