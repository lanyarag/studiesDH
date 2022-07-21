using Microsoft.AspNetCore.Mvc;
using ProjetoProdutos.Models;

namespace ProjetoProdutos.Controllers
{
    public class ProdutoController: Controller
    {
        static List<Produto> lista = new List<Produto>();
        public IActionResult Index()
        {
            lista.Add(new Produto() { NomeProduto = "Mouse", Categoria = "Informatica", Preco = 55.55, Quantidade = 23, Descricao = "Sem fio" });
            ViewBag.Produto = lista;
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Produto prod)
        {
            lista.Add(prod);
            return RedirectToAction("Index");
        }
        public IActionResult Atualizar(int? Id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Atualizar(int? id, Produto prod)
        {
            Produto produtoAlterado = new Produto();
            int i = 0;
            foreach (var item in lista)
            {
                if (item.Id == id)
                {
                    item.NomeProduto = prod.NomeProduto;
                    item.Descricao = prod.Descricao;
                    item.Categoria = prod.Categoria;
                    item.Quantidade = prod.Quantidade;
                    item.Preco = prod.Preco;
                    lista[i] = item;
                    break;
                }
                i++;
            }
            return RedirectToAction("Index");
        }
        public IActionResult Apagar()
        {
            return View();
        }

        public IActionResult Apagar(int? Id)
        {
            Produto produto = new Produto();
            {
                int i = 0;
                foreach(var item in lista)
                {
                    if (item.Id == produto.Id)
                    {
                        lista.RemoveAt(i);
                    }
                    i++;
                }
            }
            return RedirectToAction("Index");
        }

    }
}
