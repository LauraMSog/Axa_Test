import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

import { MainData } from '../mainData.model';

@Injectable({
  providedIn: 'root',
})
export class MainService {

    constructor(private http: HttpClient) { }

    private configUrl = 'https://raw.githubusercontent.com/rrafols/mobile_test/master/data.json';

    getGnomeInfo() {
        return this.http.get(this.configUrl).pipe(map((res) => res));
    }

    getData() {
        return this.http.get<MainData[]>(this.configUrl);
    }

}
