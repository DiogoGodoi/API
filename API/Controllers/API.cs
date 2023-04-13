using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MODEL;
using DAO;
using API.Interface;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class API : ControllerBase, InterfaceAPI
    {
        public DaoProduto Dao = new DaoProduto();

        [Route("/Produto/{id}")]
        [HttpPost]
        public async Task<ActionResult<bool>> Alter(Produto produto)
        {
            try
            {
                var success = await Dao.Alter(produto);
                if (success)
                {
                    return Ok(true);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [Route("/Insert")]
        [HttpPost]
        public async Task<ActionResult<bool>> Insert(Produto produto)
        {
            try
            {
                var success = await Dao.Insert(produto);
                if (success)
                {
                    return Ok(true);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [Route("/Remove/{id}")]
        [HttpPost]
        public async Task<ActionResult<bool>> Remove(int ID)
        {
            try
            {
                var success = await Dao.Remove(ID);
                if (success)
                {
                    return Ok(true);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [Route("/Produtos")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> Select()
        {
            try
            {
            var success = await Dao.Select();
                if (success.Count() > 0)
                {
                    return Ok(success);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [Route("/Produto/{id}")]
        [HttpGet]
        public async Task<ActionResult<Produto>> SelectID(int ID)
        {
            try
            {
            var success = await Dao.SelectID(ID);
                if (success != null)
                {
                    return Ok(success);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
