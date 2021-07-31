import { Injectable } from '@angular/core';
import { catchError } from 'rxjs/internal/operators';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { map } from 'rxjs/operators';
import { OrdenPedido } from '../Models/OrdenPedido';
import { Cliente } from '../Models/Cliente';
import { Producto } from '../Models/Producto';
const endpoint = 'https://localhost:44396/api/';
@Injectable({
  providedIn: 'root'
})
export class RestService {

  constructor(private http: HttpClient) { }

  getOrdenesPedidos(): Observable<any> {
    return this.http.get<OrdenPedido>(endpoint + 'pedidos').pipe(
      catchError(this.handleError)
    );
  }

  getClientes(): Observable<any> {
    return this.http.get<Cliente>(endpoint + 'clientes').pipe(
      catchError(this.handleError)
    );
  }

  getProductos(): Observable<any> {
    return this.http.get<Producto>(endpoint + 'productos').pipe(
      catchError(this.handleError)
    );
  }

  
  private extractData(res: Response): any {
    const body = res;
    return body || { };
  }

  private handleError(error: HttpErrorResponse): any {
    if (error.error instanceof ErrorEvent) {
      console.error('An error occurred:', error.error.message);
    } else {
      console.error(
        `Backend returned code ${error.status}, ` +
        `body was: ${error.error}`);
    }
    return throwError(
      'Something bad happened; please try again later.');
  }
}
