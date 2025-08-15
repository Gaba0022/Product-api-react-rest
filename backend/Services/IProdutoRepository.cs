using backend.Data.DTOs;
using backend.Models;
using System.Collections;

namespace backend.Interface;

public interface IProdutoRepository
{
    Task<IEnumerable<LerProduto>> GetProdutosAsync();
    Task<LerProduto> CriarProdutosAsync(CriarProdutoDTO dto);

}
