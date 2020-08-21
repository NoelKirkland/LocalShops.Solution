using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LocalShops.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace LocalShops.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class NeighborhoodsController : ControllerBase
  {
    private LocalShopsContext _db;

    public NeighborhoodsController(LocalShopsContext db)
    {
      _db = db;
    }

  [Authorize(Roles = Role.Admin)]
  [HttpGet]
  public ActionResult<IEnumerable<Neighborhood>> Get()
  {
    var allInfo = _db.Neighborhoods
    .Include(neighborhood => neighborhood.Restaurants)
    .Include(neighborhood => neighborhood.Shops);
    return allInfo.ToList();
  }

  [HttpGet("{id}")]
  public ActionResult<Neighborhood> Get(int id)
  {
    Neighborhood thisNeighborhood = _db.Neighborhoods
    .Include(neighborhood => neighborhood.Restaurants)
    .Include(neighborhood => neighborhood.Shops)
    .FirstOrDefault(neighborhood => neighborhood.NeighborhoodId == id);
    return thisNeighborhood;
  }

  [Authorize(Roles = Role.Admin)]
  [HttpPost]
  public void Neighborhood([FromBody] Neighborhood neighborhood)
  {
    _db.Neighborhoods.Add(neighborhood);
    _db.SaveChanges();
  }

  [Authorize(Roles = Role.Admin)]
  [HttpPut("{id}")]
  public void Put(int id, [FromBody] Neighborhood neighborhood)
  {
    var neighborhoodToChange = _db.Neighborhoods.FirstOrDefault(entry => entry.NeighborhoodId == id);
    _db.Entry(neighborhoodToChange).State = EntityState.Modified;
    _db.SaveChanges();
  }

  [Authorize(Roles = Role.Admin)]
  [HttpDelete("{id}")]
  public void Delete(int id)
  {
    var neighborhoodToDelete = _db.Neighborhoods.FirstOrDefault(entry => entry.NeighborhoodId == id);
    _db.Neighborhoods.Remove(neighborhoodToDelete);
    _db.SaveChanges();
  }
  }
}