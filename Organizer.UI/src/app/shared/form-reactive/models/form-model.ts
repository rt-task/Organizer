import { CheckInputModel } from "./check-input-model";
import { KeywordInputModel } from "./keyword-input-model";
import { RadioInputModel } from "./radio-input-model";
import { SelectInputModel } from "./select-input-model";

export interface FormModel {
    checkboxFilters: CheckInputModel[];
    radioFilters: RadioInputModel[];
    selectionFilters: SelectInputModel[];
    keywordFilters: KeywordInputModel[];
}