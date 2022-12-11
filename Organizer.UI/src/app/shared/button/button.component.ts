import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-button',
  templateUrl: './button.component.html',
  styleUrls: ['./button.component.scss']
})
export class ButtonComponent implements OnInit {

  @Input() text = "";
  @Input() buttonClassList = "button";
  @Input() wrapperClassList = "button-wrapper";
  @Input() type = "button";
  @Input() isDisabled = false;
  @Input() isHidden = false;
  @Output() clickEvent = new EventEmitter();

  constructor() { }

  ngOnInit(): void {
  }

  clickButton() {
    this.clickEvent.emit();
  }
}
