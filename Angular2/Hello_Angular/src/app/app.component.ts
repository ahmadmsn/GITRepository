import { Component } from '@angular/core';

@Component({
  selector: 'my-app',
  template:  `<h1>My Angular 2</h1>
              <h2>{{title}}<h2>`
            
})
export class AppComponent  { 
  title = "This is my Title"
               }
