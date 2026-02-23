using Service.Service;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;
using DAL.Data;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusteriController : ControllerBase
    {
        MusteriService musteriService = new MusteriService();

        [HttpGet]
        public IActionResult GetAllMusteriList()
        {
            var list = VeriTabani.GetAllVT();
            return Ok(list);
        }


        [HttpGet("{id:int}")]
        public IActionResult GetOneMusteri([FromRoute(Name = "id")] int id)
        {
            var musteri = musteriService.GetOne(id);
            if (musteri is null)
            {
                return NotFound();
            }

            return Ok(musteri);
        }


        [HttpPost]
        public IActionResult AddListMusteri([FromBody] Musteri musteri)
        {
            //if (musteri is null)
            //{
            //    return BadRequest();
            //}

            musteri.MusteriID = VeriTabani.IdSayac;
            VeriTabani.IdSayac++;

            musteriService.Add(musteri);
            return Ok();
        }


        [HttpDelete("{id:int}")]
        public IActionResult DeleteOneMusteri([FromRoute(Name = "id")] int id)
        {
            var musteri = musteriService.VarMiYokMu(id);

            if (musteri != null)
            {
                VeriTabani.Remove(musteri);
                return Ok();
            }
            return NotFound();
        }



        [HttpDelete]
        public IActionResult DeleteAllMusteri()
        {
            musteriService.AllRemove();
            return Ok();
        }

    }
}
