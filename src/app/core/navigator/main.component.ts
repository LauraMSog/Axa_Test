import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgbPaginationConfig } from '@ng-bootstrap/ng-bootstrap';

import { MainService } from './main.service';
import { MainData } from './mainData.model';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.scss'],
  providers: [NgbPaginationConfig]
})
export class MainComponent implements OnInit {

  mainData: MainData[];
  gnomeCity = 'Brastlewark';
  // gnomeInfo: any;

  page = 0;

  constructor( private router: Router, private service: MainService, config: NgbPaginationConfig ) {
    config.size = 'sm';
    config.boundaryLinks = true;
  }

  ngOnInit() {
   /* this.service.getGnomeInfo().subscribe((res) => {
      this.gnomeInfo = res['Brastlewark'];
    });
    console.log(this.gnomeInfo);*/
    this.showData();
  }

  showData() {
    this.service.getData().subscribe( data => {
      this.mainData = data[this.gnomeCity];
    });
    console.log(this.mainData);
  }

}
