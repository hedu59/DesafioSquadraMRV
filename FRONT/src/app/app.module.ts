import { BrowserModule } from '@angular/platform-browser';
import { LOCALE_ID, NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import {
  HashLocationStrategy,
  LocationStrategy,
  registerLocaleData,
} from '@angular/common';
import ptBr from '@angular/common/locales/pt';
import { ToastrModule } from 'ngx-toastr';
import { TextMaskModule } from 'angular2-text-mask';
import { NotFoundComponent } from './notFound/notFound.component';
import { InvitationComponent } from './pages/invitation/invitation.component';
import { InvitationItemComponent } from './pages/invitation-item/invitation-item.component';
import { HeaderComponent } from './pages/layouts/header/header.component';
import { MatCardModule } from '@angular/material/card';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatIconModule} from '@angular/material/icon';
import {MatTabsModule} from '@angular/material/tabs';
import {MatButtonModule} from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';

registerLocaleData(ptBr);

const  MATERIAL = [
  MatCardModule,
  MatToolbarModule,
  MatIconModule,
  MatTabsModule,
  MatButtonModule,
  MatFormFieldModule,
];

@NgModule({
  declarations: [
    AppComponent,
    NotFoundComponent,
    InvitationComponent,
    InvitationItemComponent,
    HeaderComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    FontAwesomeModule,
    HttpClientModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot(),
    TextMaskModule,
    ...MATERIAL
  ],
  providers: [
    {
      provide: LOCALE_ID,
      useValue: 'pt-BR',
    },
    {
      provide: LocationStrategy,
      useClass: HashLocationStrategy,
    },
  ],

  bootstrap: [AppComponent],
})
export class AppModule {}
