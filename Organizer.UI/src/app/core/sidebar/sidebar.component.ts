import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.scss']
})
export class SidebarComponent implements OnInit {

  constructor(private router: Router) { }

  closeSidebarSymbol = '←';
  isClosed = false;

  ngOnInit(): void {
  }

  changeState() {
    this.isClosed = !this.isClosed;
    this.closeSidebarSymbol = this.isClosed ? '→' : '←';
  }

  goToNotes() {
    this.router.navigate(['notes']);
  }
}
