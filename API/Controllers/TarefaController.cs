using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Models;

namespace API.Controllers;

[Route("api/tarefa")]
[ApiController]
public class TarefaController : ControllerBase
{
    private readonly AppDataContext _context;

    public TarefaController(AppDataContext context) =>
        _context = context;

    // GET: api/tarefa/listar
    [HttpGet]
    [Route("listar")]
    public IActionResult Listar()
    {
        try
        {
            List<Tarefa> tarefas = _context.Tarefas.Include(x => x.Categoria).ToList();
            return Ok(tarefas);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet]
    [Route("naoconcluidas")]
    public IActionResult ListarNaoConcluidas()
    {
        try
        {
            List<Tarefa> tarefas = _context.Tarefas
                                           .Include(x => x.Categoria)
                                           .Where(x => x.Status == "Não iniciada" || x.Status == "Em andamento")
                                           .ToList();
            return Ok(tarefas);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet]
    [Route("concluidas")]
    public IActionResult ListarConcluidas()
    {
        try
        {
            List<Tarefa> tarefas = _context.Tarefas
                                           .Include(x => x.Categoria)
                                           .Where(x => x.Status == "Concluída")
                                           .ToList();
            return Ok(tarefas);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    // POST: api/tarefa/cadastrar
    [HttpPost]
    [Route("cadastrar")]
    public IActionResult Cadastrar([FromBody] Tarefa tarefa)
    {
        try
        {
            Categoria? categoria = _context.Categorias.Find(tarefa.CategoriaId);
            if (categoria == null)
            {
                return NotFound();
            }
            tarefa.Categoria = categoria;
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
            return Created("", tarefa);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPatch]
    [Route("alterar/{id}")]
    public IActionResult Alterar([FromRoute] int id, [FromBody] Tarefa tarefa)
    {
        try
        {
            Tarefa? tarefaDesejada = _context.Tarefas.FirstOrDefault(t => t.TarefaId == id);
            if(tarefaDesejada != null)
            {
                if (tarefaDesejada.Status == "Não iniciada" && tarefa.Status != "Concluída")
                {
                    tarefaDesejada.Status = tarefa.Status;
                }

                if (tarefaDesejada.Status == "Em andamento" && tarefa.Status != "Não iniciada")
                {
                    tarefaDesejada.Status = tarefa.Status;
                }
                _context.Tarefas.Update(tarefaDesejada);
                _context.SaveChanges();
                return Ok(tarefaDesejada);
            }
            return NotFound("Tarefa não encontrada");
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
