import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './master.component.html',
 
})
export class MasterComponent implements OnInit {
  title(title: any) {
      throw new Error('Method not implemented.');
  }

  constructor() { }

  ngOnInit(): void {
  }

}
