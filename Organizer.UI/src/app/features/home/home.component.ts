import { Component, OnInit } from '@angular/core';
import { Validators } from '@angular/forms';
import { FormModel } from 'src/app/shared/form-reactive/models/form-model';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  formModel: FormModel = {
    checkboxFilters: [
      {
        id: 'testCheck1',
        validators: [Validators.required],
        initialValue: '',
        name: 'checkbox',
        label: 'click me 1',
        isDisabled: false,
        inputClassList: '',
        labelClassList: ''
      },
      {
        id: 'testCheck2',
        name: 'checkbox',
        label: 'click me 2',
        initialValue: '',
        isDisabled: false,
        inputClassList: '',
        labelClassList: '',
        validators: [Validators.required]
      }
    ],
    radioFilters: [
      {
        id: 'testRadio1',
        name: 'radio',
        label: 'click me 1',
        validators: [Validators.required],
        initialValue: '',
        isDisabled: false,
        inputClassList: '',
        labelClassList: ''
      },
      {
        id: 'testRadio2',
        name: 'radio',
        label: 'click me 2',
        initialValue: '',
        isDisabled: false,
        inputClassList: '',
        labelClassList: '',
        validators: [Validators.required]
      }
    ],
    selectionFilters: [
      {
        id: 'testSelect1',
        name: 'select1',
        label: 'select1',
        initialValue: '',
        isDisabled: false,
        labelClassList: '',
        inputClassList: '',
        validators: [Validators.required],
        options: [
          {
            value: '1',
            label: 'click me 1',
            inputClassList: ''
          },
          {
            value: '2',
            label: 'click me 2',
            inputClassList: ''
          },
          {
            value: '3',
            label: 'click me 3',
            inputClassList: ''
          }
        ]
      },
      {
        id: 'testSelect2',
        name: 'select2',
        label: 'select2',
        initialValue: '',
        isDisabled: false,
        labelClassList: '',
        inputClassList: '',
        validators: [Validators.required],
        options: [
          {
            value: '4',
            label: 'click me 4',
            inputClassList: ''
          },
          {
            value: '5',
            label: 'click me 5',
            inputClassList: ''
          },
          {
            value: '6',
            label: 'click me 6',
            inputClassList: ''
          }
        ]
      }
    ],
    keywordFilters: [
      {
        id: 'testText1',
        name: 'text',
        type: 'text',
        placeholder: 'text 1',
        initialValue: '',
        isDisabled: false,
        inputClassList: '',
        validators: [Validators.required]
      },
      {
        id: 'testText2',
        name: 'text',
        type: 'number',
        placeholder: '1',
        initialValue: '',
        isDisabled: false,
        inputClassList: '',
        validators: [Validators.required]
      }
    ]
  }

  constructor() { }

  ngOnInit(): void {
  }

}
