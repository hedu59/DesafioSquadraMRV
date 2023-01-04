import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { NotFoundComponent } from './notFound/notFound.component';
import { InvitationComponent } from './pages/invitation/invitation.component';


const routes: Routes = [
  {
    path: "**",
    component: InvitationComponent
  }];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
