using Microsoft.AspNetCore.Mvc;
using MODEL;

namespace API.Interface
{
    public interface InterfaceAPI
    {
        [HttpPost]
        Task<ActionResult<bool>> Insert(Produto produto);
        [HttpPost]
        Task<ActionResult<bool>> Alter(Produto produto);
        [HttpPost]
        Task<ActionResult<bool>> Remove(int ID);
        [HttpGet]
        Task<ActionResult<IEnumerable<Produto>>> Select();
        [HttpGet]
        Task<ActionResult<Produto>> SelectID(int ID);
    }
}
