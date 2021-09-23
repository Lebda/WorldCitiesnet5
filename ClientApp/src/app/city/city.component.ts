import { HttpClient } from "@angular/common/http";
import { Component, Inject, OnInit } from "@angular/core";
import { Observable, of } from "rxjs";

import { City } from "./city";

@Component({
  selector: "app-city",
  templateUrl: "./city.component.html",
  styleUrls: ["./city.component.css"],
})
export class CityComponent implements OnInit {
  public displayedColumns: string[] = ["id", "name", "lat", "lon"];
  public cities$: Observable<City[]>;

  constructor(private http: HttpClient, @Inject("BASE_URL") private baseUrl: string) {
    this.cities$ = of(new Array<City>());
  }

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
