import { Component, OnInit, Input } from '@angular/core';
import { Invitation } from '../../shared/models/Invitation';
import { InvitationService } from '../../services/invitation.service';
import { take } from 'rxjs/operators';

@Component({
  selector: 'app-invitation-item',
  templateUrl: './invitation-item.component.html',
  styleUrls: ['./invitation-item.component.css'],
})
export class InvitationItemComponent implements OnInit {
  @Input() invitation!: Invitation;

  constructor(private invitationService: InvitationService) {}

  ngOnInit(): void {

  }

  changeStatus(invitation:Invitation, status:boolean) {
    this.invitationService.changeStatusInvitations(invitation.Id, status).pipe(take(1)).subscribe(
      response=> {
      if(response.Success){
        this.invitationService.$changeStatusInvitation.next(true);
      }}
    )
  }

  getFirstLetter(name: string): string {
    return Array.from(name)[0];
  }
}
