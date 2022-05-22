using System;
using System.Threading.Tasks;
using Csla;
using Microsoft.AspNetCore.Mvc;

namespace Hullamin.Server.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DataPortalController : Csla.Server.Hosts.HttpPortalController
  {
    public DataPortalController()
    {
        UseTextSerialization = false;
    }

    [HttpGet]
    public ActionResult<string> Get()
    {
        try
        {
           return "Northwind data portal is working.";
        }
        catch (Exception ex)
        {
            return ex.ToString();
        }
    }
  }
}