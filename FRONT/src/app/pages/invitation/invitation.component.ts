import { Component, OnInit, Input } from '@angular/core';
import { Invitation } from '../../shared/models/Invitation';
import { InvitationService } from '../../services/invitation.service';
import { take } from 'rxjs/operators';
import { MatTabChangeEvent } from '@angular/material/tabs';
import { ETabName } from '../../shared/Enums/ETabName';

@Component({
  selector: 'app-invitation',
  templateUrl: './invitation.component.html',
  styleUrls: ['./invitation.component.css'],
})
export class InvitationComponent implements OnInit {
  public invitations: Invitation[] = [];
  constructor(private invitationService: InvitationService) {}

  ngOnInit(): void {
    this.invitationService.$changeStatusInvitation.subscribe((response) => {
      if (response == true) {
        this.getInvitations();
      }
    });
    this.getInvitations();
  }

  public getInvitations() {
    this.invitations = [];
    this.invitationService
      .getAvailableInvitations()
      .pipe(take(1))
      .subscribe((response) => {
        if (response.Success) {
          this.invitations = response?.Data?.Items;
        }
      });
  }

  public getAcceptedInvitations() {
    this.invitations = [];
    this.invitationService
      .getAcceptedInvitations()
      .pipe(take(1))
      .subscribe((response) => {
        if (response.Success) {
          this.invitations = response?.Data?.Items;
        }
      });
  }

  public onTabClick(event: MatTabChangeEvent) {
    if (event.tab.textLabel == ETabName.Invited) {
      this.getInvitations();
    }
    else{
      this.getAcceptedInvitations();
    }
  }
}
