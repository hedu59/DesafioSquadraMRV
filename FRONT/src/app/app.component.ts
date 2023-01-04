import { Component, OnInit } from '@angular/core';
import { TokenService } from './token/token.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'MRV';
  isLoading = false;

  constructor( private _service: TokenService ) { }

  ngOnInit() {
    this.getStatus();
  }


  public getStatus() {
    this._service.getLoading().subscribe(res => {
      this.isLoading = res;
    })
  }
}
