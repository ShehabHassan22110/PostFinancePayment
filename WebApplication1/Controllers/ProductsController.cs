using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }


        #region Get Products
        public async Task<IActionResult> Index()
        {
            var data = await productService.Get();
            return View(data);
        }

        #endregion

        #region Create Products
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,Quantity")] Product product)
        {
            if (ModelState.IsValid)
            {
                await productService.Create(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        #endregion

        #region Delete Products

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var data = await productService.GetById(id);
                productService.Delete(data);

                if (data != null)
                {
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {
                return View();

            }
            return View();


        }
        #endregion


    }
}
