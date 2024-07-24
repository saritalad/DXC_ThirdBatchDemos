import { Injectable } from '@angular/core';
import { Enquiry } from '../Models/Enquiry';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class EnquiryService {

  private apiUrl = 'https://localhost:44353/api/Enquiry';

  constructor(private http: HttpClient) { }

  // Get all enquiries
  getEnquiries(): Observable<Enquiry[]> {
    return this.http.get<Enquiry[]>(this.apiUrl);
  }

  // Get enquiry by ID
  getEnquiry(enquiryId: number): Observable<Enquiry> {
    const url = `${this.apiUrl}/${enquiryId}`;
    return this.http.get<Enquiry>(url);
  }

  // Create enquiry
  createEnquiry(enquiry: Enquiry): Observable<Enquiry> {
    return this.http.post<Enquiry>(this.apiUrl, enquiry);
  }

  // Update enquiry
  updateEnquiry(enquiryId: number, enquiry: Enquiry): Observable<Enquiry> {
    const url = `${this.apiUrl}/${enquiryId}`;
    return this.http.put<Enquiry>(url, enquiry);
  }

  // Delete enquiry
  deleteEnquiry(enquiryId: number): Observable<any> {
    const url = `${this.apiUrl}/${enquiryId}`;
    return this.http.delete(url);
  }
}
