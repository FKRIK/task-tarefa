import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Tarefa } from 'src/app/models/tarefa.model';

@Component({
  selector: 'app-tarefa-listar',
  templateUrl: './tarefa-listar.component.html',
  styleUrls: ['./tarefa-listar.component.css']
})
export class TarefaListarComponent {
  tarefas!: Tarefa[]

  tarefa!: Tarefa;
  status: string = "";
  id: number = 0;

  constructor(private client: HttpClient){ }

  ngOnInit() : void{
    // console.log("O componente foi carregado!");

    this.client.get<Tarefa[]>("https://localhost:7015/api/tarefa/listar")
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

  alterar(): void {
    

    // this.client
    //   .patch<Tarefa>(`https://localhost:7015/api/tarefa/alterar/${this.id}`, { status: this.tarefa.status })
    //   .subscribe({
    //     // Requisição com sucesso
    //     next: (data) => {
    //       console.log(data);
    //     },
    //     // Requisição com erro
    //     error: (error) => {
    //       console.log(error);
    //     }
    //   });
  }
}