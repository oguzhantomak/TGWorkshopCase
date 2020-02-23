using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TGWorkshop.Services.Contracts;
using TGWorkshopCase.Context;
using TGWorkshopCase.Entities.Model;

namespace TGWorkshopCase.UI.Controllers
{

    public class TGUsersController : Controller
    {
        
        private readonly ITGUserService _iTGUserService;

        public TGUsersController(ITGUserService itGUserService)
        {
            this._iTGUserService = itGUserService;
        }

        public IActionResult Index()
        {
            var users = _iTGUserService.GetAll();
            return View(users);
        }
    }
    //[Route("api/[controller]")]
    //[ApiController]
    //public class TGUsersController : ControllerBase
    //{
    //    private readonly TGWorkshopContext _context;

    //    public TGUsersController(TGWorkshopContext context)
    //    {
    //        _context = context;
    //    }

    //    // GET: api/TGUsers
    //    [HttpGet]
    //    public async Task<ActionResult<IEnumerable<TGUser>>> GetTGUsers()
    //    {
    //        return await _context.TGUsers.ToListAsync();
    //    }

    //    // GET: api/TGUsers/5
    //    [HttpGet("{id}")]
    //    public async Task<ActionResult<TGUser>> GetTGUser(Guid id)
    //    {
    //        var tGUser = await _context.TGUsers.FindAsync(id);

    //        if (tGUser == null)
    //        {
    //            return NotFound();
    //        }

    //        return tGUser;
    //    }

    //    // PUT: api/TGUsers/5
    //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for
    //    // more details see https://aka.ms/RazorPagesCRUD.
    //    [HttpPut("{id}")]
    //    public async Task<IActionResult> PutTGUser(Guid id, TGUser tGUser)
    //    {
    //        if (id != tGUser.Id)
    //        {
    //            return BadRequest();
    //        }

    //        _context.Entry(tGUser).State = EntityState.Modified;

    //        try
    //        {
    //            await _context.SaveChangesAsync();
    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {
    //            if (!TGUserExists(id))
    //            {
    //                return NotFound();
    //            }
    //            else
    //            {
    //                throw;
    //            }
    //        }

    //        return NoContent();
    //    }

    //    // POST: api/TGUsers
    //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for
    //    // more details see https://aka.ms/RazorPagesCRUD.
    //    [HttpPost]
    //    public async Task<ActionResult<TGUser>> PostTGUser(TGUser tGUser)
    //    {
    //        _context.TGUsers.Add(tGUser);
    //        await _context.SaveChangesAsync();

    //        return CreatedAtAction("GetTGUser", new { id = tGUser.Id }, tGUser);
    //    }

    //    // DELETE: api/TGUsers/5
    //    [HttpDelete("{id}")]
    //    public async Task<ActionResult<TGUser>> DeleteTGUser(Guid id)
    //    {
    //        var tGUser = await _context.TGUsers.FindAsync(id);
    //        if (tGUser == null)
    //        {
    //            return NotFound();
    //        }

    //        _context.TGUsers.Remove(tGUser);
    //        await _context.SaveChangesAsync();

    //        return tGUser;
    //    }

    //    private bool TGUserExists(Guid id)
    //    {
    //        return _context.TGUsers.Any(e => e.Id == id);
    //    }
    //}
}
