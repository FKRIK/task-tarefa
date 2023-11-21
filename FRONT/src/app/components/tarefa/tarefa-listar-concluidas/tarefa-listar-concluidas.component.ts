import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Tarefa } from 'src/app/models/tarefa.model';

@Component({
  selector: 'app-tarefa-listar-concluidas',
  templateUrl: './tarefa-listar-concluidas.component.html',
  styleUrls: ['./tarefa-listar-concluidas.component.css']
})
export class TarefaListarConcluidasComponent {
  tarefas!: Tarefa[]

  constructor(private client: HttpClient){ }

  ngOnInit() : void{
    // console.log("O componente foi carregado!");

    this.client.get<Tarefa[]>("https://localhost:7015/api/tarefa/concluidas")
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
