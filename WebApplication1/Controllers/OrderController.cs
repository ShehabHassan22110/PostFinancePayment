using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Dtos;
using WebApplication1.Interfaces;

namespace WebApplication1.Controllers
{
    public class OrderController : Controller
    {
        private readonly IProductService productService;

        public OrderController(IProductService productService)
        {
            this.productService = productService;
        }

        #region PaymentWay
        public async Task<IActionResult> PaymentWay(int id)
        {
            TempData["ProductId"] = id;
            var order = await productService.GetById(id);
            ViewBag.TotalPrice = order.Price;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> PaymentWay(PaymentWayDto dto)
        {
          
                var ProductId = Convert.ToInt32(TempData["ProductId"]);
                TempData["ProductId"] = ProductId;

                if (dto.PaymentWay == "VISA")
                {
                return RedirectToAction("VisaPayment");
                }
                 if (dto.PaymentWay == "PostFinance")
                {
                    return RedirectToAction("PostFinancePayment");
                }
                if (dto.PaymentWay == "Twint")
                {
                    return RedirectToAction("TwintPayment");
                }
                return View();
            
        }
        #endregion


        #region PostFinance Payment way
        [HttpGet]
        public async Task<IActionResult> PostFinancePayment()
        {

                var ProductId = Convert.ToInt32(TempData["ProductId"]);
                var product = productService.GetById(ProductId);             
                TempData["ProductId"] = ProductId;                    
               return View();
        }

        //[HttpPost]
        //public IActionResult PostFinancePayment(PaymentDto dto)
        //{
        //    try
        //    {

        //    }
        //    catch (Exception)
        //    {
        //        return View();
        //    }
        //}
        #endregion

        #region Twint Payment way
        [HttpGet]
        public async Task<IActionResult> TwintPayment()
        {

            var ProductId = Convert.ToInt32(TempData["ProductId"]);
            var product = await productService.GetById(ProductId);
            ViewBag.Price = product.Price;
            TempData["ProductId"] = ProductId;
            return View();
        }
        #endregion

        #region Visa Payment way
        [HttpGet]
        public async Task<IActionResult> VisaPayment()
        {

            var ProductId = Convert.ToInt32(TempData["ProductId"]);
            var product = await productService.GetById(ProductId);
            ViewBag.Price = product.Price;
            TempData["ProductId"] = ProductId;
            return View();
        }
        #endregion
    }
}
