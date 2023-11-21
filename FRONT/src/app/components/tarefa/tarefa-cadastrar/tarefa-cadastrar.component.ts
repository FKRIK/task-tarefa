import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Categoria } from 'src/app/models/categoria.model';
import { Tarefa } from 'src/app/models/tarefa.model';

@Component({
  selector: 'app-tarefa-cadastrar',
  templateUrl: './tarefa-cadastrar.component.html',
  styleUrls: ['./tarefa-cadastrar.component.css']
})
export class TarefaCadastrarComponent {
  titulo: string = "";
  descricao: string = "";
  status: string = "";
  categoriaId: number = 0;
  categorias?: Categoria[];


  constructor(private client: HttpClient, private router: Router) { }

  ngOnInit(): void {
    this.client.get<Categoria[]>("https://localhost:7015/api/categoria/listar").subscribe({
      //A requição funcionou
      next: (data) => {
        console.table(data);
        this.categorias = data;
      },
      //A requição não funcionou
      error: (erro) => {
        console.log(erro);
      },
    });
  }

  cadastrar(): void{
    let tarefa: Tarefa = {
      titulo: this.titulo,
      descricao: this.descricao,
      categoriaId: this.categoriaId
    }

    console.log(tarefa);

    this.client.post<Tarefa>("https://localhost:7015/api/tarefa/cadastrar", tarefa)
    .subscribe({
      next: (data) => {
        this.router.navigate(["tarefas/listar"]);
        console.table(data);
      },
      error: (erro) => {
        console.log(erro);
      },
    });
  }
}
