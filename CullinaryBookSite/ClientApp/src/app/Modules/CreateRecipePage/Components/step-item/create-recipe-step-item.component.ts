import { Component, Input, OnInit, Output, EventEmitter } from "@angular/core";
import { StepDto } from "src/app/Dtos/stepDto";

@Component({
    selector: 'app-step-item',
    templateUrl:'./create-recipe-step-item.component.html',
    styleUrls: ['../../../../../assets/styles/create-recipe-step-item.css']
})

export class CreateRecipeStepItemComponent implements OnInit {
    @Input() public step!: StepDto;
    @Output() public delete = new EventEmitter<StepDto>();

    deleteClicked(): void
    {
        this.delete.emit(this.step);
    }

    ngOnInit(): void {}
}
