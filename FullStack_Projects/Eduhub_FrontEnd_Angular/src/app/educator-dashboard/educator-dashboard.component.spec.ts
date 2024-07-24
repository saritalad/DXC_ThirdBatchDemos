import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EducatorDashboardComponent } from './educator-dashboard.component';

describe('EducatorDashboardComponent', () => {
  let component: EducatorDashboardComponent;
  let fixture: ComponentFixture<EducatorDashboardComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EducatorDashboardComponent]
    });
    fixture = TestBed.createComponent(EducatorDashboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
