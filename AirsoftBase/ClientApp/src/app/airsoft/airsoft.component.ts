import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';



@Component({
  selector: 'app-airsoft',
  templateUrl: './airsoft.component.html',
  styleUrls: ['./airsoft.component.scss']
})
export class AirsoftComponent{

  public Airsoft: airsofts[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<airsofts[]>(baseUrl + 'airsofts').subscribe(result => {
      this.Airsoft = result;
    }, error => console.error(error));
  }
}

interface airsofts {
  Brand: string;
  Type: string;
  Name: string;
  MagazineSize: number;
  FPS: number;
  Caliber: number;
  Joule: number;
  GearBox: string;
  Lenght: number;
  Weight: number;
  Battery: boolean;
  Description: string;
  Price: number;
}
