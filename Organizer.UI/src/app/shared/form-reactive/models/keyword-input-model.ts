import { FormElement } from "./form-element";

export interface KeywordInputModel extends FormElement {
    name: string;
    type: string;
    placeholder: string;
    isDisabled: boolean;
    inputClassList: string;
}
