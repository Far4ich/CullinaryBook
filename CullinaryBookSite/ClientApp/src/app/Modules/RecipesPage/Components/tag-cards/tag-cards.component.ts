import { Component, Input } from "@angular/core";
import { Tag } from "../../Shared/tag";

@Component({
    selector: 'tag-cards',
    templateUrl: 'tag-cards.component.html',
    styleUrls: ['../../../../../assets/styles/tag-cards.css']
})

export class TagCardsComponent { 
    @Input() public tag!: Tag;
}