export interface OrdenPedido {
    fechaRegistro: Date;
    cliente: string;
    estado: string;
    direccionEntrega: string;
    prioridad: string;
    valorTotal: number;
  }