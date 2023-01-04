import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Observable } from 'rxjs/internal/Observable';
import { environment } from '../environments/environment';
import { RetornoConsultaDivida } from './token/RetornoToken';


export interface IRequestOptions {
  headers?: HttpHeaders;
  observe?: 'body';
  params?: HttpParams;
  reportProgress?: boolean;
  responseType?: 'json';
  withCredentials?: boolean;
  body?: any;
  contentType?:"application/json";
}

@Injectable({
    providedIn: 'root'
})

export class ApiHttpClient {

    private dadosUsuario = new BehaviorSubject<RetornoConsultaDivida>(undefined);

    private readonly api = (path: string) =>
    [environment.urlBase, path].join('/');

  constructor(private http: HttpClient) {}

  /**
   * GET request
   * @param {string} endPoint it doesn't need / in front of the end point
   * @param {IRequestOptions} options options of the request like headers, body, etc.
   * @param {string} api use if there is needed to send request to different back-end than the default one.
   * @returns {Observable<T>}
   */
  public get<T>(endPoint: string, options?: IRequestOptions): Observable<T> {
    return this.http.get<T>(this.api(endPoint), options);
  }

  /**
   * POST request
   * @param {string} endPoint end point of the api
   * @param {Object} params body of the request.
   * @param {IRequestOptions} options options of the request like headers, body, etc.
   * @returns {Observable<T>}
   */
  public post<T>(
    endPoint: string,
    params: Object,
    options?: IRequestOptions
  ): Observable<T> {
    return this.http.post<T>(this.api(endPoint), params, options);
  }

  /**
   * PUT request
   * @param {string} endPoint end point of the api
   * @param {Object} params body of the request.
   * @param {IRequestOptions} options options of the request like headers, body, etc.
   * @returns {Observable<T>}
   */
  public put<T>(
    endPoint: string,
    params: Object,
    options?: IRequestOptions
  ): Observable<T> {
    return this.http.put<T>(this.api(endPoint), params, options);
  }

  /**
   * DELETE request
   * @param {string} endPoint end point of the api
   * @param {IRequestOptions} options options of the request like headers, body, etc.
   * @returns {Observable<T>}
   */
  public delete<T>(endPoint: string, options?: IRequestOptions): Observable<T> {
    return this.http.delete<T>(this.api(endPoint), options);
  }

    getUser(): Observable<RetornoConsultaDivida> {
        return this.dadosUsuario.asObservable();
    }
}
