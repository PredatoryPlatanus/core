import { Component } from '@angular/core';
import { Http } from '@angular/http';
import {IWeatherForecast }  from '.././models/iweatherforecast';

@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})
export class FetchDataComponent {
    public forecasts: IWeatherForecast[];

    constructor(http: Http) {
        http.get('/api/SampleData/WeatherForecasts').subscribe(result => {
            this.forecasts = result.json() as IWeatherForecast[];
        });
    }
}

