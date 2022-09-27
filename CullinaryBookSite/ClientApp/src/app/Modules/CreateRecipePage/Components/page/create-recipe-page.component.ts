import { Component, ElementRef, OnInit, ViewChild } from "@angular/core";
import { Location } from '@angular/common';
import { RecipeEditDto } from "src/app/Dto/recipeEditDto";
import { MatChipInputEvent } from '@angular/material/chips'
import { COMMA, ENTER } from '@angular/cdk/keycodes';
import { TagDto } from "src/app/Dto/tagDto";
import { OptionNumber } from "../../Shared/option-number";
import { IngredientDto } from "src/app/Dto/ingredientDto";
import { StepDto } from "src/app/Dto/stepDto";
import { RecipeService } from "src/app/Services/recipe.service";

@Component({
    templateUrl:'./create-recipe-page.component.html',
    styleUrls: ['../../../../../assets/styles/create-recipe-page.css'],
    providers: [RecipeService]
})

export class CreateRecipePageComponent implements OnInit{

    @ViewChild('inputImage') inputImageRef!: ElementRef;
    public viewImage: string | ArrayBuffer | null = null;

    readonly separatorKeysCodes = [ENTER, COMMA] as const;

    constructor(private _location: Location,
        private _recipeService: RecipeService) {}
 
    ngOnInit(): void {}

    backClicked() {
        this._location.back();
    }

    numberOfServingsOptions: OptionNumber[] = [
        {value: 1, viewValue: '1'},
        {value: 2, viewValue: '2'},
        {value: 3, viewValue: '3'},
        {value: 4, viewValue: '4'},
        {value: 5, viewValue: '5'},
        {value: 6, viewValue: '6'},
    ]

    cookingMinutesOptions: OptionNumber[] = [
        {value: 10, viewValue: '10'},
        {value: 15, viewValue: '15'},
        {value: 30, viewValue: '30'},
        {value: 60, viewValue: '60'},
        {value: 120, viewValue: '120'},
        {value: 180, viewValue: '180'},
      ];

    recipe: RecipeEditDto = {
        title: "",
        description: "",
        cookingMinutes: 0,
        numberOfServings: 0,
        image: null,
        authorId: 1,
        tags: [],
        ingredients: [
            {
                title: "",
                orderNumber: 1,
                products: ""
            }
        ],
        steps: [
            {
                orderNumber: 1,
                description: ""
            }
        ]
    };

    addTag(event: MatChipInputEvent): void {
        const value = (event.value || '').trim();

        if (value) {
          this.recipe.tags.push({title: value});
        }

        event.chipInput!.clear();
      }
    
    removeTag(tag: TagDto): void {
        const index = this.recipe.tags.indexOf(tag);

        if (index >= 0) {
            this.recipe.tags.splice(index, 1);
        }
    }

    addIngredient(): void
    {
        this.recipe.ingredients.push(
            {
                title: "",
                orderNumber: this.recipe.ingredients[this.recipe.ingredients.length - 1].orderNumber + 1,
                products: ""
            }
        )
    }

    removeIngredient(ingredient: IngredientDto): void
    {
        const ingredientsLength = this.recipe.ingredients.length;
        if (ingredientsLength > 1)
        {
            const index = this.recipe.ingredients.indexOf(ingredient);
            this.recipe.ingredients.splice(index, 1);
            var i:number; 
            for(i = index;i <= ingredientsLength - 2;i++)
            {
                this.recipe.ingredients[i].orderNumber--;
            }
        }
    }

    addStep(): void
    {
        this.recipe.steps.push(
            {
                orderNumber: this.recipe.steps[this.recipe.steps.length - 1].orderNumber + 1,
                description: ""
            }
        )
    }

    removeStep(step: StepDto): void
    {
        const stepsLength = this.recipe.steps.length;
        if (stepsLength > 1)
        {
            const index = this.recipe.steps.indexOf(step);
            this.recipe.steps.splice(index, 1);
            var i:number; 
            for(i = index;i <= stepsLength - 2;i++)
            {
                this.recipe.steps[i].orderNumber--;
            }
        }
    }

    isValidRecipe(): boolean
    {
        if (this.recipe.title.length == 0)
        {
            alert("Название рецепта не может быть пустым");
            return false;
        }
        if (this.recipe.description.length == 0)
        {
            alert("Описание рецепта не может быть пустым");
            return false;
        }
        if (this.recipe.cookingMinutes == 0)
        {
            alert("Выберите время готовки");
            return false;
        }
        if (this.recipe.numberOfServings == 0)
        {
            alert("Количество порций");
            return false;
        }
        if (this.recipe.ingredients.find(x => x.title == ""))
        {
            alert("Заголовок для ингредиентов не может быть пустым");
            return false;
        }
        if (this.recipe.ingredients.find(x => x.products == ""))
        {
            alert("Список продуктов для категории не может быть пустым");
            return false;
        }
        if (this.recipe.steps.find(x => x.description == ""))
        {
            alert("Описание шага не может быть пустым");
            return false;
        }
        return true;
    }

    createRecipe(): void
    {  
        if (this.isValidRecipe())
        {
            const formData = new FormData();
            formData.append("title", this.recipe.title);
            formData.append("description", this.recipe.description);
            formData.append("cookingMinutes", this.recipe.cookingMinutes.toString());
            formData.append("numberOfServings", this.recipe.numberOfServings.toString());
            formData.append("image", this.recipe.image!);
            formData.append("authorId", this.recipe.authorId.toString());
            let i = 0;
            this.recipe.tags.forEach(element=>{
                formData.append("tags[" + i + "].title", element.title);
                i++;
            });
            i = 0;
            this.recipe.ingredients.forEach(element=>{
                formData.append("ingredients[" + i + "].title", element.title);
                formData.append("ingredients[" + i + "].orderNumber", element.orderNumber.toString());
                formData.append("ingredients[" + i + "].products", element.products);
                i++;
            });
            i = 0;
            this.recipe.steps.forEach(element=>{
                formData.append("steps[" + i + "].orderNumber", element.orderNumber.toString());
                formData.append("steps[" + i + "].description", element.description);
                i++;
            });
            this._recipeService.addRecipe(formData).subscribe(()=>{alert("Рецепт был создан")});
        }
    }

    inputImageClick()
    {
        this.inputImageRef.nativeElement.click()
    }

    imageChange(event: any)
    {
        const reader = new FileReader();
        const file = event.target.files[0];
        this.recipe.image = <File>event.target.files[0];

        reader.onload = (e) => {
            this.viewImage = e.target!.result;
        }
        reader.readAsDataURL(file);
    }
}