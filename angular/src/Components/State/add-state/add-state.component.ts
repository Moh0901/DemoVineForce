import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ServiceService } from 'src/services/service.service';

@Component({
  selector: 'app-add-state',
  templateUrl: './add-state.component.html',
  styleUrls: ['./add-state.component.css']
})
export class AddStateComponent implements OnInit {

  constructor(private stateService:ServiceService, private router:Router) { }

  ngOnInit(): void {
  }

  addStateForm = new FormGroup({
    name : new FormControl("", [Validators.required]),
  })

  AddStateSubmitted(){
    this.stateService.addState({
      name:this.addStateForm.value.name
    }).subscribe((res)=>{
        alert('State Added Successfully')
        console.log(res);
        this.router.navigate(['/get-state']);
    })
  }
}
