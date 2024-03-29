import { Component, OnInit } from '@angular/core';
import { ServiceService } from 'src/services/service.service';

@Component({
  selector: 'app-get-state',
  templateUrl: './get-state.component.html',
  styleUrls: ['./get-state.component.css']
})
export class GetStateComponent {

  countries: any;
  selectedCountry: any;
  states: any;
  loadingStates = false;

  constructor(private countryService: ServiceService, private stateService: ServiceService) {
    this.getCountries();
  }

  getCountries() {
    this.countryService.getCountries()
      .subscribe(data => {
        this.countries = data;
      });
  }

  getStates() {
    this.loadingStates = true;
    this.stateService.getStates(this.selectedCountry)
      .subscribe(data => {
        this.states = data;
        this.loadingStates = false;
      }, error => {
        this.loadingStates = false;
      });
  }
}
