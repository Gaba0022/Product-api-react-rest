using backend.Data.DTOs;
using backend.Interface;

namespace backend.Services;

public class ProdutoRepository: IProdutoRepository
{
    public async Task<IEnumerable<LerProduto>> GetProdutosAsync()
    {

    }
    public async Task<LerProduto> CriarProdutosAsync(CriarProdutoDTO dto)
    {

    }
}
