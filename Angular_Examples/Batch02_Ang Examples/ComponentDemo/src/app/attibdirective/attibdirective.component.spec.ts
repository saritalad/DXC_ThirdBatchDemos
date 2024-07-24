import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AttibdirectiveComponent } from './attibdirective.component';

describe('AttibdirectiveComponent', () => {
  let component: AttibdirectiveComponent;
  let fixture: ComponentFixture<AttibdirectiveComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AttibdirectiveComponent]
    });
    fixture = TestBed.createComponent(AttibdirectiveComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
