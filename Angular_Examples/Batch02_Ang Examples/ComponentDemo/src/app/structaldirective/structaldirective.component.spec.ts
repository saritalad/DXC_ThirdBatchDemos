import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StructaldirectiveComponent } from './structaldirective.component';

describe('StructaldirectiveComponent', () => {
  let component: StructaldirectiveComponent;
  let fixture: ComponentFixture<StructaldirectiveComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [StructaldirectiveComponent]
    });
    fixture = TestBed.createComponent(StructaldirectiveComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
