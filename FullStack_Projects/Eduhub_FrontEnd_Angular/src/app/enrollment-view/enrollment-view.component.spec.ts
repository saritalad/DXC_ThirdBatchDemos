import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EnrollmentViewComponent } from './enrollment-view.component';

describe('EnrollmentViewComponent', () => {
  let component: EnrollmentViewComponent;
  let fixture: ComponentFixture<EnrollmentViewComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EnrollmentViewComponent]
    });
    fixture = TestBed.createComponent(EnrollmentViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
