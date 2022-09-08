import { Component, Input } from "@angular/core";

@Component({
    selector: 'app-step-item',
    templateUrl:'./create-recipe-step-item.component.html',
    styleUrls: ['../../../../../assets/styles/create-recipe-step-item.css']
})

export class CreateRecipeStepItemComponent{
    @Input() public stepOrder!: number;
}
