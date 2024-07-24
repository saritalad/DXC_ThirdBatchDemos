import { CanDeactivateFn } from '@angular/router';

export const unSavedDataGuard: CanDeactivateFn<unknown> = (component, currentRoute, currentState, nextState) => {
  return true;
};
