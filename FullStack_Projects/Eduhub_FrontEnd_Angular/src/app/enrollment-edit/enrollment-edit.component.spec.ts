import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EnrollmentEditComponent } from './enrollment-edit.component';

describe('EnrollmentEditComponent', () => {
  let component: EnrollmentEditComponent;
  let fixture: ComponentFixture<EnrollmentEditComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EnrollmentEditComponent]
    });
    fixture = TestBed.createComponent(EnrollmentEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
