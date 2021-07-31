import { Component, OnInit } from '@angular/core';
import { Cliente } from 'src/app/Models/Cliente';
import { Producto } from 'src/app/Models/Producto';
import { RestService } from 'src/app/Services/rest.service';

@Component({
  selector: 'app-registro',
  templateUrl: './registro.component.html',
  styleUrls: ['./registro.component.css']
})
export class RegistroComponent implements OnInit {
  clientes: Cliente[] = []
  productos: Producto[] = []
  constructor(private rest: RestService) { }

  ngOnInit(): void {
    this.rest.getClientes().subscribe(res => {
      this.clientes = res;
    });
    this.rest.getProductos().subscribe(res => {
      this.productos = res;
    });
  }

}
