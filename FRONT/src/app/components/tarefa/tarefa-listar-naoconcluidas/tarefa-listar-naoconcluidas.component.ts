import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Tarefa } from 'src/app/models/tarefa.model';

@Component({
  selector: 'app-tarefa-listar-naoconcluidas',
  templateUrl: './tarefa-listar-naoconcluidas.component.html',
  styleUrls: ['./tarefa-listar-naoconcluidas.component.css']
})
export class TarefaListarNaoconcluidasComponent {
  tarefas!: Tarefa[]

  constructor(private client: HttpClient){ }

  ngOnInit() : void{
    // console.log("O componente foi carregado!");

    this.client.get<Tarefa[]>("https://localhost:7015/api/tarefa/naoconcluidas")
      .subscribe({
        //Requisição com sucesso
        next: (data) => {
          this.tarefas = data;
          // console.table(data);
        }, 
        //Requisição com erro
        error: (error) => {
          console.log(error);
        }
      })
  }
}
