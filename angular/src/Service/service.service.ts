import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ServiceService {

  constructor(private http: HttpClient) { }

  baseUl = "https://localhost:44311/"

  getAllStates():Observable<any>{
    return this.http.get(this.baseUl+"api/State")
  }

  getStateById(id:any):Observable<any>{
    return this.http.get(this.baseUl+"api/State/"+id)
  }

  addState(state:any):Observable<any>{
    return this.http.post(this.baseUl+"api/State/",state)
  }

  editState(id:any, state:any):Observable<any>{
    return this.http.put(this.baseUl+"api/State/"+id,state)
  }

  removeState(id:any):Observable<any>{
    return this.http.delete(this.baseUl+"api/State/"+id)
  }

  getAllCountry():Observable<any>{
    return this.http.get(this.baseUl+"api/Country")
  }

  getCountryById(id:any):Observable<any>{
    return this.http.get(this.baseUl+"api/Country/"+id)
  }

  addCountry(country:any):Observable<any>{
    return this.http.post(this.baseUl+"api/Country/",country)
  }

  editCountry(id:any, country:any):Observable<any>{
    return this.http.put(this.baseUl+"api/Country/"+id,country)
  }

  removeCountry(id:any):Observable<any>{
    return this.http.delete(this.baseUl+"api/Country/"+id)
  }

}
