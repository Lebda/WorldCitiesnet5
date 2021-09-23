import { HttpClient } from "@angular/common/http";
import { Component, Inject, OnInit } from "@angular/core";
import { Observable } from "rxjs";

import { City } from "./city";

@Component({
  selector: "app-city",
  templateUrl: "./city.component.html",
  styleUrls: ["./city.component.css"],
})
export class CityComponent implements OnInit {
  public cities$: Observable<City[]> | undefined;

  constructor(private http: HttpClient, @Inject("BASE_URL") private baseUrl: string) {}

  public ngOnInit() {
    this.cities$ = this.http.get<City[]>("https://localhost:44355/" + "api/Cities");
    this.cities$.subscribe(
      (result) => {},
      (error) => {
        console.error(error);
      }
    );
  }
}
