import { Component, OnInit } from '@angular/core';
import { OrdenPedido } from 'src/app/Models/OrdenPedido';
import { RestService } from 'src/app/Services/rest.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  displayedColumns: string[] = ['fechaRegistro', 'cliente', 'estado', 'direccionEntrega', 'prioridad', 'valorTotal'];
  dataSource: OrdenPedido[] = []

  constructor(private rest: RestService) { }

  ngOnInit(): void {
    this.rest.getOrdenesPedidos().subscribe(res => {
      this.dataSource = res;
    });
  }
}
