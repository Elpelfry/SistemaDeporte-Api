﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.Models;
using SistemaDeporteApi.DAL;

namespace SistemaDeporteApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class JugadoresController(Contexto _context) : ControllerBase
{
    // GET: api/Jugadores
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Jugadores>>> GetJugadores()
    {
        return Ok(await _context.Jugadores.ToListAsync());
    }

    // GET: api/Jugadores/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Jugadores>> GetJugadores(int id)
    {
        var jugadores = await _context.Jugadores.FindAsync(id);

        if (jugadores == null)
        {
            return NotFound();
        }

        return Ok(jugadores);
    }

    // PUT: api/Jugadores/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutJugadores(int id, Jugadores jugadores)
    {
        if (id != jugadores.JugadorId)
        {
            return BadRequest();
        }

        _context.Entry(jugadores).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!JugadoresExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return Ok(NoContent());
    }

    // POST: api/Jugadores
    [HttpPost]
    public async Task<ActionResult<Jugadores>> PostJugadores(Jugadores jugadores)
    {
        _context.Jugadores.Add(jugadores);
        await _context.SaveChangesAsync();

        return Ok(CreatedAtAction("GetJugadores", new { id = jugadores.JugadorId }, jugadores));
    }

    // DELETE: api/Jugadores/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteJugadores(int id)
    {
        var jugadores = await _context.Jugadores.FindAsync(id);
        if (jugadores == null)
        {
            return NotFound();
        }

        _context.Jugadores.Remove(jugadores);
        await _context.SaveChangesAsync();

        return Ok(NoContent());
    }

    private bool JugadoresExists(int id)
    {
        return _context.Jugadores.Any(e => e.JugadorId == id);
    }
}