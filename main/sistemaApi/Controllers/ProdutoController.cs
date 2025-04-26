using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sistemaApi.Models;

[ApiController]
[Route("api/[controller]")]
public class ProdutoController : ControllerBase
{
    private readonly AppDbContext _context;

    public ProdutoController (AppDbContext context)
    {
     _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetProdutos() => Ok(await _context.Produtos.ToListAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProduto (int id)
    {
        var produto = await _context.Produtos.FindAsync(id);
        return produto == null  ? NotFound() : Ok(produto); 
    }

    [HttpPost]
    public async Task<IActionResult> CriarProduto([FromBody] Produto produto)
    {
        _context.Produtos.Add(produto);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetProduto), new { id = produto.Id }, produto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> AtualizarProduto (int id, [FromBody] Produto produto)
    {
        if(id != produto.Id) return BadRequest();
        _context.Entry(produto).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletarProduto (int id)
    {
        var produto = await _context.Produtos.FindAsync (id);
        if(produto == null) return NotFound();
        _context.Produtos.Remove(produto);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
