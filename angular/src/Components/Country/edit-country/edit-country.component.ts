import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { ServiceService } from 'src/services/service.service';

@Component({
  selector: 'app-edit-country',
  templateUrl: './edit-country.component.html',
  styleUrls: ['./edit-country.component.css']
})
export class EditCountryComponent implements OnInit {

  constructor(private stateService:ServiceService, private activeRoute:ActivatedRoute) { }

  
  editCountryForm = new FormGroup({
    name : new FormControl("", [Validators.required]),
  })

  ngOnInit(): void {

      this.stateService.getCountryById(this.activeRoute.snapshot.params['id'])
      .subscribe((res:any)=>{
        console.log(res)
        this.editCountryForm= new FormGroup({
          name: new FormControl(res["name"],[Validators.required]),
        })
    })
   }

   editStateSubmitted(){
    this.stateService.editCountry(this.activeRoute.snapshot.params['id'],{
      name: this.editCountryForm.value.name,
    }).subscribe(res=>{
      console.log(res);
      alert('Country Edited Successfully')
    })
  }

}
