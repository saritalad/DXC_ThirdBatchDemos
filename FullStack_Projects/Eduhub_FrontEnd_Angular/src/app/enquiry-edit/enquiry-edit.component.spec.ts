import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EnquiryEditComponent } from './enquiry-edit.component';

describe('EnquiryEditComponent', () => {
  let component: EnquiryEditComponent;
  let fixture: ComponentFixture<EnquiryEditComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EnquiryEditComponent]
    });
    fixture = TestBed.createComponent(EnquiryEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
