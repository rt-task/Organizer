import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-notes',
  templateUrl: './notes.component.html',
  styleUrls: ['./notes.component.scss']
})
export class NotesComponent implements OnInit {

  noteList = [
    { id: 1, priority: 5, isCompleted: false, title: 'test1', content: 'Lorem ipsum dolor sit amet consectetur adipisicing elit. Quasi eaque nobis id perspiciatis voluptatum similique incidunt consequatur laudantium.' },
    { id: 2, priority: 1, isCompleted: true, title: 'test2', content: 'Lorem ipsum dolor sit amet consectetur adipisicing elit. Quasi eaque nobis id perspiciatis voluptatum similique incidunt consequatur laudantium, quisquam ab facere laboriosam illum natus rem doloribus optio dolorem architecto necessitatibus!' },
    { id: 3, priority: 2, isCompleted: false, title: 'test3', content: 'Lorem ipsum dolor sit amet consectetur adipisicing elit. Quasi eaque nobis id perspiciatis voluptatum similique incidunt consequatur laudantium, quisquam ab facere laboriosam illum natus rem doloribus optio dolorem architecto necessitatibus!' },
    { id: 4, priority: 3, isCompleted: false, title: 'test4', content: 'Lorem ipsum dolor sit amet consectetur adipisicing elit. Quasi eaque nobis id perspiciatis voluptatum similique incidunt consequatur laudantium, quisquam ab facere laboriosam illum natus rem doloribus optio dolorem architecto necessitatibus!' },
    { id: 5, priority: 2, isCompleted: false, title: 'test5', content: 'Lorem ipsum dolor sit amet consectetur adipisicing elit.' },
    { id: 6, priority: 4, isCompleted: true, title: 'test6', content: 'Lorem ipsum dolor sit amet consectetur adipisicing elit. Quasi eaque nobis id perspiciatis voluptatum similique incidunt consequatur laudantium, quisquam ab facere laboriosam illum natus rem doloribus optio dolorem architecto necessitatibus!' }
  ]

  constructor(private router: Router) { }

  ngOnInit(): void {
  }

  goToDetails(noteId: number) {
    this.router.navigate(['details', noteId]);
  }

  completeNote(noteId: number) {
    console.log('completed ', noteId);
  }

  deleteNote(noteId: number) {
    console.log('deleted ', noteId);
  }
}
