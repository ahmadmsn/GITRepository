import { Component } from '@angular/core';

@Component({
  selector: 'user',
  template: `
      <h1>{{name}}</h1>
      <p><strong>Email: </strong>{{Email}}</p>
      <p><strong>Adrees:</strong> {{Address.Street}} {{Address.City}} {{Address.State}}</p>
      <button (click)= "toggleHobbies()">{{showHobbies ? "Hide Hobbies" : "Show Hobbies"}}</button>
      <div *ngIf ="showHobbies">
        <h3>Hobbies</h3>
        <ul>
          <li *ngFor="let hobby of hobbies ;let i = index">
            {{hobby}} <button (click)="deleteHobby(i)">x</button>
          </li>
        </ul>
        <form (submit)="addHobby(hobby.value)">
          <label>Add Hobby:</label><br />
          <input type="text" #hobby /> <br />
        </form>
      </div>
      <hr />
      <h3>Edit User:</h3>
      <form>
        <label>Name:</label><br />
        <input type="text" name="name" [(ngModel)]="name" /> <br />
        <label>Email:</label><br />
        <input type="text" name="email" [(ngModel)]="Email" /> <br />
        <label>Street:</label><br />
        <input type="text" name="Address.Street" [(ngModel)]="Address.Street" /> <br />
        <label>City:</label><br />
        <input type="text" name="Address.City" [(ngModel)]="Address.City" /> <br />
        <label>State:</label><br />
        <input type="text" name="Address.State" [(ngModel)]="Address.State" /> <br />        
      </form>
      `,
})
export class UserComponent {
  name: string;
  Email:string;
  Address:address;
  hobbies:string[];
  showHobbies:boolean;
       /*name = 'Angular';
       Email = 'myemail@email.com'
       Address = {
         Street: '12 Main street',
         City:'Boston',
         State:'NA'
        }*/
    constructor(){
      this.name = 'Angular';
       this.Email = 'myemail@email.com'
       this.Address = {
         Street: '12 Main street',
         City:'Boston',
         State:'NA'        
        }
        this.hobbies =['Music','Movies','Sports'];     
        this.showHobbies=false;
    }
    toggleHobbies(){
      if (this.showHobbies==true){
        this.showHobbies=false;
      }
      else{
        this.showHobbies=true;
      }
  }
  addHobby(hobby:any){
    this.hobbies.push(hobby);
  }
  deleteHobby(i:any){
    this.hobbies.splice(i,1);
  }


}

interface address{
  Street:string;
  City:string,
  State:string;
}
