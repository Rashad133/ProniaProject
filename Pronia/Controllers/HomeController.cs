using Microsoft.AspNetCore.Mvc;
using Pronia.DAL;
using Pronia.Models;
using Pronia.ViewModels;

namespace Pronia.Controllers
{
	public class HomeController : Controller
	{
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
		{


			
			List<Slide> slides= _context.Sliders.OrderBy(s=>s.Order).Take(2).ToList();

			List<Product> products = new List<Product>
			{
				new Product
				{
					
					Name="American Marigold",
					Price=24,
					Image="1-2-270x300.jpg"
                },
                new Product
                {
                    
                    Name="Black Eyed Susan",
                    Price=45,
                    Image="1-3-270x300.jpg",
                    
                },
                new Product
                {
                    
                    Name="Bleeding Heart",
                    Price=42,
                    Image="1-4-270x300.jpg"
                },
                new Product
                {
                    
                    Name="Bloody Cranesbill",
                    Price=40,
                    Image="1-5-270x300.jpg"
                },
                new Product
                {
                    
                    Name="Butterfly Weed",
                    Price=38,
                    Image="1-6-270x300.jpg"
                },
                new Product
                {
                    
                    Name="Common Yarrow",
                    Price=50,
                    Image="1-7-270x300.jpg"
                },
                new Product
                {
                    
                    Name="Doublefile Viburnum",
                    Price=54,
                    Image="1-1-270x300.jpg"
                },
                new Product
                {
                    
                    Name="Feather Reed Grass",
                    Price=44,
                    Image="1-2-270x300.jpg"
                },
                new Product
                {
                    
                    Name="Lale",
                    Price=38,
                    Image="1-6-270x300.jpg"
                },
                new Product
                {
                    
                    Name="QizilGul",
                    Price=29,
                    Image="1-11-270x300.jpg"
                },


            };

            _context.Products.AddRange(products);
            _context.SaveChanges();


			//List<Product> products =_context.Sliders.OrderByDescending(p=>p.Order).Take(8).ToList();

			HomeVM vm = new HomeVM()
			{
				Slides = slides,
				

			};

			return View(vm);
		}
	}
}
