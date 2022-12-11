import { Component, Input, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { FormElement } from './models/form-element';
import { FormModel } from './models/form-model';

@Component({
  selector: 'app-form-reactive',
  templateUrl: './form-reactive.component.html',
  styleUrls: ['./form-reactive.component.scss']
})
export class FormReactiveComponent implements OnInit {

  @Input() formModel!: FormModel;
  mainForm: FormGroup;

  constructor(private fb: FormBuilder) { 
    this.mainForm = this.fb.group({});
  }

  buildFormGroup(formElementGroup: FormElement[]) {
    return this.fb.group(
      formElementGroup.map(element =>
        this.fb.group({
          [element.id]: [element.initialValue, element.validators]
        })
      )
    )
  }

  ngOnInit(): void {
    let checkboxGroup = this.buildFormGroup(this.formModel.checkboxFilters);
    let radioGroup = this.buildFormGroup(this.formModel.radioFilters);
    let selectGroup = this.buildFormGroup(this.formModel.selectionFilters);
    let keywordGroup = this.buildFormGroup(this.formModel.keywordFilters);
    
    this.mainForm = this.fb.group({
      checkboxGroup: checkboxGroup,
      radioGroup: radioGroup,
      selectGroup: selectGroup,
      keywordGroup: keywordGroup
    });
    
  }

}
