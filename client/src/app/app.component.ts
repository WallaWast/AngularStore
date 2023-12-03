import { Component, OnInit } from '@angular/core';
import { BasketService } from './basket/basket.service';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'WaStore';

  constructor(private basketService: BasketService) { }

  ngOnInit(): void {
    const basketId = localStorage.getItem(environment.localStorageBasketIdStr);

    if (basketId) this.basketService.getBasket(basketId);
  }
}
