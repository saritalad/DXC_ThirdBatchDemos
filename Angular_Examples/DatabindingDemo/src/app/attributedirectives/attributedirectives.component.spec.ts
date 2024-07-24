import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AttributedirectivesComponent } from './attributedirectives.component';

describe('AttributedirectivesComponent', () => {
  let component: AttributedirectivesComponent;
  let fixture: ComponentFixture<AttributedirectivesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AttributedirectivesComponent]
    });
    fixture = TestBed.createComponent(AttributedirectivesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
