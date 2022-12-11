import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ButtonComponent } from './button/button.component';
import { CardComponent } from './card/card.component';
import { RouterModule } from '@angular/router';
import { PipesModule } from '../core/services/pipes/pipes.module';
import { FormReactiveComponent } from './form-reactive/form-reactive.component';
import { ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    ButtonComponent,
    CardComponent,
    FormReactiveComponent
  ],
  imports: [
    CommonModule,
    RouterModule,
    PipesModule,
    ReactiveFormsModule
  ],
  exports: [
    ButtonComponent,
    CardComponent,
    FormReactiveComponent
  ]
})
export class SharedModule { }
