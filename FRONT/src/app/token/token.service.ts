import { Injectable } from '@angular/core';
import { RetornoConsultaDivida } from './RetornoToken';
import { ApiHttpClient } from '../base';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class TokenService {
  private dadosUsuario = new BehaviorSubject<RetornoConsultaDivida>(undefined);
  private loading = new BehaviorSubject<boolean>(false);
  private esconderLogin = new BehaviorSubject<boolean>(false);

  constructor(private base: ApiHttpClient) {}

  public autenticarCliente(dados) {
    return this.base.post<RetornoConsultaDivida>(
      'TokenCliente/ClientePorDevedorId',
      dados
    );
  }

  setUser(user: RetornoConsultaDivida): void {
    this.dadosUsuario.next(user);
  }

  getUser(): Observable<RetornoConsultaDivida> {
    return this.dadosUsuario.asObservable();
  }

  setLoading(isLoading: boolean): void {
    this.loading.next(isLoading);
  }

  getLoading(): Observable<boolean> {
    return this.loading.asObservable();
  }

  setLogin(isLoading: boolean): void {
    this.esconderLogin.next(isLoading);
  }

  getLogin(): Observable<boolean> {
    return this.esconderLogin.asObservable();
  }
}
