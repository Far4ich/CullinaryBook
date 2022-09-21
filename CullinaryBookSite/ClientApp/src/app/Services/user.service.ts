import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { HttpClient } from "@angular/common/http";
import { LikeDto } from "../Dto/likeDto";
import { FavoriteDto } from "../Dto/favoriteDto";

@Injectable()
export class UserService {
    private readonly apiUrl: string = 'http://localhost:4200/api/user';

    constructor(private httpClient: HttpClient) {
    }

    public getLikes(userId: number) : Observable<LikeDto[]>
    {
        return this.httpClient.get<LikeDto[]>(`${this.apiUrl}/get-likes/${userId}`);
    }

    public getFavorites(userId: number) : Observable<FavoriteDto[]>
    {
        return this.httpClient.get<FavoriteDto[]>(`${this.apiUrl}/get-favorites/${userId}`);
    }
}