import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ServiceService } from 'src/services/service.service';

@Component({
  selector: 'app-add-country',
  templateUrl: './add-country.component.html',
  styleUrls: ['./add-country.component.css']
})
export class AddCountryComponent implements OnInit {

  constructor(private countryService:ServiceService) { }

  ngOnInit(): void {
  }

  addCountryForm = new FormGroup({
    name : new FormControl("", [Validators.required]),
  })

  AddCountrySubmitted(){
    this.countryService.addCountry({
      name:this.addCountryForm.value.name
    }).subscribe((res)=>{
        alert('Country Added Successfully')
        console.log(res);
    })
  }
}
