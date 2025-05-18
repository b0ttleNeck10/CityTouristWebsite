using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CityTouristWebsite.Models;
using CityTouristWebsite.Models.ViewModels;

namespace CityTouristWebsite.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index(string? searchQuery, int page = 1)
    {
        int pageSize = 8;

        var query = _context.TouristPlaces.AsQueryable();

        if (!string.IsNullOrWhiteSpace(searchQuery))
        {
            query = query.Where(p =>
                p.PlaceName.Contains(searchQuery) ||
                p.Description.Contains(searchQuery));
        }

        var totalItems = query.Count();

        var places = query
            .OrderBy(p => p.PlaceName)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();

        var model = new TouristPlaceListViewModel
        {
            Places = places,
            PagingInfo = new PagingInfo
            {
                CurrentPage = page,
                ItemsPerPage = pageSize,
                TotalItems = totalItems
            }
        };

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Add(TouristPlaceListViewModel model)
    {
        if (model.NewPlace.ImageFile != null)
        {
            // Generate a unique filename
            string uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/places");
            Directory.CreateDirectory(uploadsFolder); // Ensure the folder exists

            string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(model.NewPlace.ImageFile.FileName);
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await model.NewPlace.ImageFile.CopyToAsync(fileStream);
            }

            model.NewPlace.ImagePath = "/images/places/" + uniqueFileName;
        }

        // Save to DB
        _context.TouristPlaces.Add(model.NewPlace);
        await _context.SaveChangesAsync();

        // Redirect back to Index
        return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
        var place = _context.TouristPlaces.FirstOrDefault(p => p.Id == id);
        if (place == null)
        {
            return NotFound();
        }

        return View(place);
    }
}
