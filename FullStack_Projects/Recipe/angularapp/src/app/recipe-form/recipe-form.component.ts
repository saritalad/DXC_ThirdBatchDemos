import { Component } from '@angular/core';
import { Recipe } from '../models/recipe.model';
import { RecipeService } from '../services/recipe.service'; // Corrected import statement
import { Router } from '@angular/router';


@Component({
  selector: 'app-recipe-form',
  templateUrl: './recipe-form.component.html',
  styleUrls: ['./recipe-form.component.css']
})

export class RecipeFormComponent {
  newRecipe: Recipe = {
    recipeId: 0,
    name: '',
    description: '',
    ingredients: '',
    instructions: '',
    author: ''
  };
  
  formSubmitted = false; // Track form submission

  constructor(private recipeService: RecipeService, private router: Router) { }

  addRecipe(): void {
    this.formSubmitted = true; // Set formSubmitted to true on form submission
    if (this.isFormValid()) {
      this.recipeService.addRecipe(this.newRecipe).subscribe(() => {
        console.log('Recipe added successfully!');
        this.router.navigate(['/viewRecipes']);
      });
    }
  }

  isFieldInvalid(fieldName: string): boolean {
    const field = this.newRecipe[fieldName];
    return !field && (this.formSubmitted || this.newRecipe[fieldName].touched);
  }

  isFormValid(): boolean {
    return !this.isFieldInvalid('name') && !this.isFieldInvalid('description') &&
      !this.isFieldInvalid('ingredients') && !this.isFieldInvalid('instructions') &&
      !this.isFieldInvalid('author');
  }
}

