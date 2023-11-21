import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from "@angular/common/http";

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TarefaListarComponent } from './components/tarefa/tarefa-listar/tarefa-listar.component';
import { TarefaCadastrarComponent } from './components/tarefa/tarefa-cadastrar/tarefa-cadastrar.component';
import { FormsModule } from '@angular/forms';
import { TarefaListarConcluidasComponent } from './components/tarefa/tarefa-listar-concluidas/tarefa-listar-concluidas.component';
import { TarefaListarNaoconcluidasComponent } from './components/tarefa/tarefa-listar-naoconcluidas/tarefa-listar-naoconcluidas.component';

@NgModule({
  declarations: [
    AppComponent,
    TarefaListarComponent,
    TarefaCadastrarComponent,
    TarefaListarConcluidasComponent,
    TarefaListarNaoconcluidasComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
