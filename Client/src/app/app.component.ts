import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  title = 'The Dating App';
  users: any;

  constructor(private http: HttpClient) {

  }
  ngOnInit() {

    // getUsers();
    this.getUsers();

  }

  getUsers() {  //this.users = http.get('https://localhost:5001/api/users').subscribe();
    this.http.get('https://localhost:5001/api/users').subscribe(response => {
      this.users = response;
      console.log(this.users)
    }, error => {
      console.log(error)
    }
    );

  }
}
