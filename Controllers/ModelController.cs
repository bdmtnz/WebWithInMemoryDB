using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using InMemory.Models;

namespace InMemory.Controllers
{
    [Route("api/model")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        private readonly MContext Mcontext;

        public ModelController(MContext context){
            Mcontext = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Modell>>> GetModels()
        {   
            return await Mcontext.model.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Modell>> SetModel(Modell model)
        {   
            await Mcontext.model.AddAsync(model);
            await Mcontext.SaveChangesAsync();
            return await Mcontext.model.FindAsync(model.Nit);
        }       
        
    }
}