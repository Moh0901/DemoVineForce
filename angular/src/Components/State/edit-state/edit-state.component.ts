import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ServiceService } from 'src/services/service.service';
import { ActivatedRoute, Router } from '@angular/router';
@Component({
  selector: 'app-edit-state',
  templateUrl: './edit-state.component.html',
  styleUrls: ['./edit-state.component.css']
})
export class EditStateComponent implements OnInit {

  constructor(private stateService:ServiceService, private activeRoute:ActivatedRoute, private router:Router) { }

  
  editStateForm = new FormGroup({
    name : new FormControl("", [Validators.required]),
  })

  ngOnInit(): void {

      this.stateService.getStateById(this.activeRoute.snapshot.params['id'])
      .subscribe((res:any)=>{
        console.log(res)
        this.editStateForm= new FormGroup({
          name: new FormControl(res["name"],[Validators.required]),
        })
    })
   }

   editStateSubmitted(){
    this.stateService.editState(this.activeRoute.snapshot.params['id'],{
      name: this.editStateForm.value.name,
    }).subscribe(res=>{
      console.log(res);
      alert('State Edited Successfully')
      this.router.navigate(['/get-state']);
    })
  }
}
