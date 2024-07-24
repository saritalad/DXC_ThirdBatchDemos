import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MaterialMyViewComponent } from './material-my-view.component';

describe('MaterialMyViewComponent', () => {
  let component: MaterialMyViewComponent;
  let fixture: ComponentFixture<MaterialMyViewComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [MaterialMyViewComponent]
    });
    fixture = TestBed.createComponent(MaterialMyViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
