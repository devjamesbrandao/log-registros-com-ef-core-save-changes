using Log.Context;
using Log.Models;

var contexto = new ProdutoContext();

var produto = new Produto
{
    Preco = 25,
    Descricao = "Mouse"
};

Console.WriteLine("Inserindo registro");

contexto.Produtos.Add(produto);

await contexto.SaveChangesAsync();

System.Console.WriteLine("Atualizando registro");

var produtoAtualizado = contexto.Produtos.FirstOrDefault();

produtoAtualizado.Preco = 20;

contexto.Update(produtoAtualizado);

await contexto.SaveChangesAsync();