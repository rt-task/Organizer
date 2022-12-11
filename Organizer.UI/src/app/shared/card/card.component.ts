import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.scss']
})
export class CardComponent implements OnInit {

  @Input() id = 0;
  @Input() title = '';
  @Input() content = '';
  @Input() classList = '';
  @Input() navigationText = '';
  @Input() firstButtonText = '';
  @Input() secondButtonText = '';
  @Input() firstButtonHidden = false;
  @Output() navigationEvent = new EventEmitter<number>();
  @Output() firstClickEvent = new EventEmitter();
  @Output() secondClickEvent = new EventEmitter();

  constructor() { }

  ngOnInit(): void {
  }

  navigate() {
    this.navigationEvent.emit(this.id);
  }

  firstButtonClick() {
    this.firstClickEvent.emit(this);
  }

  secondButtonClick() {
    this.secondClickEvent.emit(this);
  }
}
