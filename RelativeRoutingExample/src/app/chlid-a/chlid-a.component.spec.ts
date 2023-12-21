import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChlidAComponent } from './chlid-a.component';

describe('ChlidAComponent', () => {
  let component: ChlidAComponent;
  let fixture: ComponentFixture<ChlidAComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ChlidAComponent]
    });
    fixture = TestBed.createComponent(ChlidAComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
