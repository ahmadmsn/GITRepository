import { Component } from '@angular/core';
import {PostsService} from '../services/posts.service'

@Component({
    moduleId:module.id,
    selector: 'user',
    templateUrl:'user.component.html';
    providers: [PostsService]
})
export class UserComponent {
  name: string;
  Email:string;
  Address:address;
  hobbies:string[];
  showHobbies:boolean;
  posts : Post[];
       /*name = 'Angular';
       Email = 'myemail@email.com'
       Address = {
         Street: '12 Main street',
         City:'Boston',
         State:'NA'
        }*/
    constructor(private postsService : PostsService){
      this.name = 'Angular';
       this.Email = 'myemail@email.com'
       this.Address = {
         Street: '12 Main street',
         City:'Boston',
         State:'NA'        
        }
        this.hobbies =['Music','Movies','Sports'];     
        this.showHobbies=false;
        this.postsService.getPost().subscribe(posts => {
            this.posts =posts;
        });
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

interface Post{
  id:number;
  title:string,
  body:string;
}
