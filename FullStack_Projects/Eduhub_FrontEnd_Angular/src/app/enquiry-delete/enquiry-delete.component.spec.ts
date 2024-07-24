import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EnquiryDeleteComponent } from './enquiry-delete.component';

describe('EnquiryDeleteComponent', () => {
  let component: EnquiryDeleteComponent;
  let fixture: ComponentFixture<EnquiryDeleteComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EnquiryDeleteComponent]
    });
    fixture = TestBed.createComponent(EnquiryDeleteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
