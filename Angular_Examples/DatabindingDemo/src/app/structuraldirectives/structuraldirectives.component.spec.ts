import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StructuraldirectivesComponent } from './structuraldirectives.component';

describe('StructuraldirectivesComponent', () => {
  let component: StructuraldirectivesComponent;
  let fixture: ComponentFixture<StructuraldirectivesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [StructuraldirectivesComponent]
    });
    fixture = TestBed.createComponent(StructuraldirectivesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
