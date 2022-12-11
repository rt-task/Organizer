import { FormElement } from "./form-element";
import { OptionInputModel } from "./option-input-model";


export interface SelectInputModel extends FormElement {
    name: string;
    label: string;
    isDisabled: boolean;
    inputClassList: string;
    labelClassList: string;
    options: OptionInputModel[];
}
