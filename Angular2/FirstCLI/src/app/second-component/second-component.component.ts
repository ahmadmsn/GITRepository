import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-second-component',
  templateUrl: './second-component.component.html',
  styleUrls: ['./second-component.component.css']
})
export class SecondComponentComponent implements OnInit {

  public myToDo =[
    'My 1',
    'My 2'

  ];

  public  myVar ="This is inside second app class";

  constructor() { }

  ngOnInit() {
    this.myVar="Override inside init function()";
  }
  ngOnButonClick(){
    this.myVar="Changed after button click";
  }

}
