import { TestBed } from '@angular/core/testing';
import { CanDeactivateFn } from '@angular/router';

import { unSavedDataGuard } from './un-saved-data.guard';

describe('unSavedDataGuard', () => {
  const executeGuard: CanDeactivateFn = (...guardParameters) => 
      TestBed.runInInjectionContext(() => unSavedDataGuard(...guardParameters));

  beforeEach(() => {
    TestBed.configureTestingModule({});
  });

  it('should be created', () => {
    expect(executeGuard).toBeTruthy();
  });
});
