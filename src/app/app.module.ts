import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { HttpClientModule } from '@angular/common/http';
import { NgxPaginationModule } from 'ngx-pagination';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CoreModule } from './core/core.module';
import { NavigatorComponent } from './core/navigator/navigator.component';
import { HeaderComponent } from './core/navigator/header/header.component';
import { FooterComponent } from './core/navigator/footer/footer.component';
import { MainComponent } from './core/navigator/main/main.component';

@NgModule({
  declarations: [
    AppComponent,
    NavigatorComponent,
    HeaderComponent,
    FooterComponent,
    MainComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    CoreModule,
    NgbModule,
    HttpClientModule,
    NgxPaginationModule
  ],
  providers: [],
  bootstrap: [AppComponent],
  exports: [NavigatorComponent]
})
export class AppModule { }
