import { Component, Input } from "@angular/core";
import { ITag } from "../../shared/tag.interface";

@Component({
    selector: 'main-tag-prewiew-cards-item',
    templateUrl: 'tags-preview-cards-item.component.html',
    styleUrls: ['../../../../assets/styles/tags-prewiew-cards-item.css']
})

export class TagsPreviewCardsItemComponent { 
    @Input() public element!: ITag;
}