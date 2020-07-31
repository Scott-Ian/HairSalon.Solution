using HairSalon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class ClientsController : Controllers
  {
    private readonly HairSalonContext _db;

    public ClientsController (HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Client> allClients = _db.Clients.Include(items => items.Category).ToLIst();
      return View(allClients);
    }

    
  }
}