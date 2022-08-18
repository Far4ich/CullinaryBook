import { Component, Input } from "@angular/core";
import { Tag } from "../../shared/tag";

@Component({
    selector: 'tag-prewiew-cards-item',
    templateUrl: 'tags-preview-cards-item.component.html',
    styleUrls: ['../../../../../assets/styles/tags-prewiew-cards-item.css']
})

export class TagsPreviewCardsItemComponent { 
    @Input() public tag!: Tag;
}