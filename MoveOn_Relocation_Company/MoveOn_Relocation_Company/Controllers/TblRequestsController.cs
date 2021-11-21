using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoveOn_Relocation_Company.Models;

namespace MoveOn_Relocation_Company.Controllers
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

        [HttpGet("JobApplicationNumber")]
        //GET :api/TblRequests/JobApplicationNumber
        public async Task<ActionResult<TblRequest>> JobApplicationNumber()
        {
            var tblRequest = _context.TblRequests.OrderByDescending( e => e.RowId).First();

            if (tblRequest == null)
            {
                return NotFound();
            }

            return tblRequest;
        }

        [HttpGet("DomesticRequests")]
        // GET: api/TblRequests/Domestic
        public async Task<ActionResult<IEnumerable<TblRequest>>> DomesticRequests()
        {
            var tblProduct = _context.TblRequests.Where(o => o.ShipmentType == "DOMESTIC").OrderByDescending(e => e.RowId).ToListAsync();

            if (tblProduct == null)
            {
                return NotFound();
            }

            return await tblProduct;
        }

        [HttpGet("InternationalRequests")]
        // GET: api/TblRequests/International
        public async Task<ActionResult<IEnumerable<TblRequest>>> InternationalRequests()
        {
            var tblProduct = _context.TblRequests.Where(o => o.ShipmentType == "INTERNATIONAL").OrderByDescending(e => e.RowId).ToListAsync();

            if (tblProduct == null)
            {
                return NotFound();
            }

            return await tblProduct;
        }


        // GET: api/TblRequests/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblRequest>> GetTblRequest(int id)
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
        public async Task<IActionResult> PutTblRequest(int id, TblRequest tblRequest)
        {
            if (id != tblRequest.RowId)
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
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblRequest", new { id = tblRequest.RowId }, tblRequest);
        }

        // DELETE: api/TblRequests/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTblRequest(int id)
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

        private bool TblRequestExists(int id)
        {
            return _context.TblRequests.Any(e => e.RowId == id);
        }
    }
}
