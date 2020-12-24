using Microsoft.AspNetCore.Mvc;
using ShoppingApp.WebUI.Infrastructure;
using ShoppingApp.WebUI.Models;
using ShoppingApp.WebUI.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.WebUI.Controllers
{
    public class CardController : Controller
    {
        private IProductRepository repository;
        public CardController(IProductRepository _repository)
        {
            repository = _repository;
        }

        public IActionResult Index()
        {
            return View(GetCard());
        }

        public IActionResult AddToCard(int ProuctId, int quantity = 1)
        {
            var product = repository.Get(ProuctId);

            //veritabanında bu değer varsa
            if (product != null)
            {
                var card = GetCard();

                card.AddProduct(product, quantity);

                SaveCard(card);
            }

            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromCard(int ProductId)
        {

            var product = repository.Get(ProductId);

            if (product != null)
            {
                var card = GetCard();

                card.RemoveProduct(product);

                SaveCard(card);
            }
            return RedirectToAction("Index");
        }

        private void SaveCard(Card card)
        {
            //Card diye bir değişken tanımladım objemi buna attım
            HttpContext.Session.SetJson("Card", card);
        }

        private Card GetCard()
        {
            return  HttpContext.Session.GetJson<Card>("Card") ?? new Card();
        }
    }
}
