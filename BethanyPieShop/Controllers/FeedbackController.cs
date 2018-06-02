using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanyPieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanyPieShop.Controllers
{
    public class FeedbackController : Controller
    {
        public readonly IFeedbackRepository feedbackRepository;
        public FeedbackController(IFeedbackRepository repository)
        {
            feedbackRepository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Feedback feed)
        {
            if (ModelState.IsValid)
            {
                feedbackRepository.AddFeedback(feed);
                return RedirectToAction("FeedbackComplete");
            }
            else
                return View(feed);
        }

        public IActionResult FeedbackComplete()
        {
            return View();
        }
    }
}