import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home/home.component';
import { NotesComponent } from './notes/notes.component';
import { SharedModule } from '../shared/shared.module';
import { ShortenTextPipe } from '../core/services/pipes/shorten-text.pipe';
import { ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    HomeComponent,
    NotesComponent
  ],
  imports: [
    CommonModule,
    SharedModule
  ]
})
export class FeaturesModule { }
