using Dapper;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DaoProduto : DAOInterface
    {
        public async Task<bool> Alter(Produto produto)
        {
            try
            {
                using (var conectar = DaoConexao.GetConection())
                {
                    conectar.Open();
                    var query = "UPDATE Produtos SET descricao = @descricao, preco = @preco, tipoUn = @tipoUn, quantidade = @quantidade WHERE ID = @ID";
                    var produtos = await conectar.ExecuteAsync(query, produto);
                    if (produtos > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }
            finally
            {

            }
        }
        public async Task<bool> Insert(Produto produto)
        {
            try
            {
                using (var conectar = DaoConexao.GetConection())
                {
                    conectar.Open();
                    var query = "INSERT INTO Produtos (descricao, preco, tipoUn, quantidade) VALUES (@descricao, @preco, @tipoUn, @quantidade)";
                    var produtos = await conectar.ExecuteAsync(query, produto);
                    if (produtos > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }
            finally
            {

            }
        }
        public async Task<bool> Remove(int id)
        {
            try
            {
                using (var conectar = DaoConexao.GetConection())
                {
                    conectar.Open();
                    var query = "DELETE FROM Produtos WHERE ID = @ID";
                    var produtos = await conectar.ExecuteAsync(query, new {ID = id});
                    if (produtos > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }
            finally
            {

            }
        }
        public async Task<IEnumerable<Produto>> Select()
        {
            try
            {
                using (var conectar = DaoConexao.GetConection())
                {
                    conectar.Open();
                    var query = "SELECT * FROM produtos";
                    var produtos = await conectar.QueryAsync<Produto>(query);
                    if (produtos.Count() > 0)
                    {
                        return produtos;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }
            finally
            {

            }
        }
        public async Task<Produto> SelectID(int id)
        {
            try
            {
                using (var conectar = DaoConexao.GetConection())
                {
                    conectar.Open();
                    var query = "SELECT * FROM produtos WHERE ID = @ID";
                    var produtos = await conectar.QueryFirstOrDefaultAsync<Produto>(query, new { ID = id });
                    if (produtos != null)
                    {
                        return produtos;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }
            finally
            {

            }
        }
    }
}
