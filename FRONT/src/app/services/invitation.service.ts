import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { ApiHttpClient, IRequestOptions } from '../base';
import { ResultDefault } from '../shared/models/ResultDefault';

@Injectable({
  providedIn: 'root',
})
export class InvitationService {
  $changeStatusInvitation = new BehaviorSubject<boolean | undefined>(undefined);

  constructor(private http: ApiHttpClient, private client: HttpClient) {}

  public getAvailableInvitations(): Observable<ResultDefault> {
    return this.http.get('Invitation/GetAvailable');
  }

  public getAcceptedInvitations(): Observable<ResultDefault> {
    return this.http.get('Invitation/GetAceppted');
  }

  public changeStatusInvitations(invitationIdNumber: number,statusInvitation: boolean): Observable<ResultDefault> {

    return this.http.put<ResultDefault>(`Invitation/UpdateInvitation?invitationId=${invitationIdNumber}&status=${statusInvitation}`, null);
  }

}
