using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoveOn_Application_Api.Models;

namespace MoveOn_Application_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblRequestsController : ControllerBase
    {
        private readonly MOVEON_DBContext _context;

        public TblRequestsController(MOVEON_DBContext context)
        {
            _context = context;
        }

        // GET: api/TblRequests
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblRequest>>> GetTblRequests()
        {
            return await _context.TblRequests.ToListAsync();
        }

        [HttpGet("DomesticRequests/1")]
        // GET: api/TblRequests/Domestic
        public async Task<ActionResult<IEnumerable<TblRequest>>> DomesticRequests()
        {
            var tblProduct = _context.TblRequests.Where(o => o.ShipmentTypeId == 1).ToListAsync();

            if (tblProduct == null)
            {
                return NotFound();
            }

            return await tblProduct;
        }

        [HttpGet("InternationalRequests/2")]
        // GET: api/TblRequests/International
        public async Task<ActionResult<IEnumerable<TblRequest>>> InternationalRequests()
        {
            var tblProduct = _context.TblRequests.Where(o => o.ShipmentTypeId == 2).ToListAsync();

            if (tblProduct == null)
            {
                return NotFound();
            }

            return await tblProduct;
        }

        // GET: api/TblRequests/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblRequest>> GetTblRequest(string id)
        {
            var tblRequest = await _context.TblRequests.FindAsync(id);

            if (tblRequest == null)
            {
                return NotFound();
            }

            return tblRequest;
        }

        // PUT: api/TblRequests/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblRequest(string id, TblRequest tblRequest)
        {
            if (id != tblRequest.JobApplicationNumber)
            {
                return BadRequest();
            }

            _context.Entry(tblRequest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblRequestExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TblRequests
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TblRequest>> PostTblRequest(TblRequest tblRequest)
        {
            _context.TblRequests.Add(tblRequest);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TblRequestExists(tblRequest.JobApplicationNumber))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTblRequest", new { id = tblRequest.JobApplicationNumber }, tblRequest);
        }

        // DELETE: api/TblRequests/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTblRequest(string id)
        {
            var tblRequest = await _context.TblRequests.FindAsync(id);
            if (tblRequest == null)
            {
                return NotFound();
            }

            _context.TblRequests.Remove(tblRequest);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TblRequestExists(string id)
        {
            return _context.TblRequests.Any(e => e.JobApplicationNumber == id);
        }
    }
}
