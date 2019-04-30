using Microsoft.AspNetCore.Mvc;
using ParcelsShippingStore.Models;
using System.Collections.Generic;


namespace ParcelsShippingStore.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/items")]
    public ActionResult Index(int height, int width, int weight)
    {
      Parcel newParcel = new Parcel(height, width, weight);
      return View(newParcel);
    }

    [HttpGet("/items/new")]
    public ActionResult ShippingForm()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(int height, int width, int weight)
    {
      Parcel myParcels = new Parcel(height, width, weight);
      return RedirectToAction("Index");
    }


  }
}
