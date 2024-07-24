import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StudentDashBoardComponent } from './student-dash-board.component';

describe('StudentDashBoardComponent', () => {
  let component: StudentDashBoardComponent;
  let fixture: ComponentFixture<StudentDashBoardComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [StudentDashBoardComponent]
    });
    fixture = TestBed.createComponent(StudentDashBoardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
