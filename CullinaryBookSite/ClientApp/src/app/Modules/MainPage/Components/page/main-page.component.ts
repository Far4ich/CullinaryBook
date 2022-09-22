import { Component } from "@angular/core";
import { SearchTag } from "../../Shared/recipe-search-tag";
import { Tag } from "../../Shared/tag";

@Component({
    templateUrl:'./main-page.component.html',
    styleUrls: ['../../../../../assets/styles/main-page.css']
})

export class MainPageComponent{
    public tags: Tag[] = [
        {
            title: "Простые блюда",
            description: "Время приготвления таких блюд не более 1 часа",
            picture: "../../../../assets/images/ic-menu.svg"
        },
        {
            title: "Детское",
            description: "Самые полезные блюда которые можно детям любого возраста",
            picture: "../../../../assets/images/ic-cook.svg"
        },
        {
            title: "От шеф-поваров",
            description: "Требуют умения, времени и терпения, зато как в ресторане",
            picture: "../../../../assets/images/ic-chef.svg"
        },
        {
            title: "На праздник",
            description: "Чем удивить гостей, чтобы все были сыты за праздничным столом",
            picture: "../../../../assets/images/holiday.svg"
        }
    ];

    public searchTags: SearchTag[] = [
        {
            title: "Мясо"
        },
        {
            title: "Деликатесы"
        },
        {
            title: "Пироги"
        },
        {
            title: "Рыба"
        }
    ]
}