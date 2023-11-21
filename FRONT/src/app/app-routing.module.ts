import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TarefaListarComponent } from './components/tarefa/tarefa-listar/tarefa-listar.component';
import { TarefaCadastrarComponent } from './components/tarefa/tarefa-cadastrar/tarefa-cadastrar.component';
import { TarefaListarConcluidasComponent } from './components/tarefa/tarefa-listar-concluidas/tarefa-listar-concluidas.component';
import { TarefaListarNaoconcluidasComponent } from './components/tarefa/tarefa-listar-naoconcluidas/tarefa-listar-naoconcluidas.component';

const routes: Routes = [
  {
    path: "tarefas/listar",
    component: TarefaListarComponent
  },
  {
    path: "tarefa/cadastrar",
    component: TarefaCadastrarComponent
  },
  {
    path: "tarefas/listar/concluidas",
    component: TarefaListarConcluidasComponent
  },
  {
    path: "tarefas/listar/naoconcluidas",
    component: TarefaListarNaoconcluidasComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
