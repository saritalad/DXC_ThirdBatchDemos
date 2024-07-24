import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, catchError, throwError } from 'rxjs';
import { Material } from '../Models/Material';

@Injectable({
  providedIn: 'root'
})
export class MaterialService {
  private apiUrl = 'https://localhost:44353/api/material';
  private apiUrl1='https://localhost:44353/api/Material/GetMaterialsByCourseId'
  httpOptions = { headers: new HttpHeaders({ 'Content-type': 'application/json' }) };
  constructor(private http: HttpClient) { }

  // Get all materials
  getMaterials(): Observable<Material[]> {
    return this.http.get<Material[]>(this.apiUrl);
  }

  // Get material by ID
  getMaterialByCourseId(Id: number): Observable<Material> {
   // const url = `${this.apiUrl}/${materialId}`;
    return this.http.get<Material>(this.apiUrl1+"/"+Id);
  }
getMaterial(id:number):Observable<Material>
{
  return this.http.get<Material>(this.apiUrl+"/"+id);
}

  // Create material
  createMaterial(material: Material): Observable<Material> {
    return this.http.post<Material>(this.apiUrl, material,this.httpOptions).pipe(catchError(this.handleError));
  }

  // Update material
  updateMaterial(material: Material): Observable<Material> {
       return this.http.put<Material>(this.apiUrl+"/"+material.materialId,material,this.httpOptions).pipe(catchError(this.handleError));
  }

  // Delete material
  deleteMaterial(materialId: number): Observable<any> {
    const url = `${this.apiUrl}/${materialId}`;
    return this.http.delete(url);
  }
  handleError(error:HttpErrorResponse){
    let errorMessage="";
    errorMessage=error.status +'\n'+error.statusText+'\n'+error.error;
    alert(errorMessage);
    return throwError(errorMessage);
  }
}
