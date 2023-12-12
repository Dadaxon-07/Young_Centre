using Microsoft.AspNetCore.Mvc;
using Young_Centre.Model;
using Young_Centre.Repository.User;

namespace Young_Centre.Controllers
{
    public class EmployeController:ControllerBase
    {
        private readonly IEmployeServise _employe;
        public EmployeController(IEmployeServise employe)
        {
            _employe = employe;

        }
        [HttpDelete]
        public async Task<IActionResult> Delate(string name, bool employe)
        {
            var get = await _employe.DeletAsync(name, employe);
            if (get.Code == 200 && get.Data is true)
            {

                return StatusCode(StatusCodes.Status200OK, get);


            }
            if (get.Code == 500 && get.Data is false)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, get);


            }
            return StatusCode(StatusCodes.Status404NotFound, get);


        }
        [HttpPost]
        public async Task<IActionResult> SignUp([FromForm] Employe employe)
        {
            var res = await _employe.SignUpAsync(employe);
            if (res.Code == 201 && res.Data is not null)
            {
                return StatusCode(StatusCodes.Status201Created, res.Data);
            }

            else if (res.Code == 302 && res.Data is not null)
            {
                return StatusCode(StatusCodes.Status302Found, res.Data);

            }
            return StatusCode(StatusCodes.Status500InternalServerError, res.Data);
        }
        [HttpPatch]
        public async Task<IActionResult> Update(int id, [FromForm] Employe entity)
        {
            var del = await _employe.UpdateAsync(id, entity);
            if (del.Code == 200 && del.Data is true)
            {
                return Ok(del);
            }
            if (del.Code == 500 && del.Data is false)
            {
                return Ok(del);
            }
            return NotFound(del);

        }
        [HttpGet]
        public async Task<IActionResult> GetAllData()
        {
            var get = await _employe.GetAllDataAsync();
            if (get.Code == 200 && get.Data is not null)
            {

                return StatusCode(StatusCodes.Status200OK, get);


            }
            if (get.Code == 500 && get.Data is not null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, get);


            }
            return StatusCode(StatusCodes.Status404NotFound, get);


        }

    }
}
