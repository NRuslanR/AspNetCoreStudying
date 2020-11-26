using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mvc.Areas.Tests.Model.BuiltInTagHelpers;

namespace Mvc.Areas.Tests.Controllers
{
    [Area("Tests")]
    public class BuiltInTagHelpersController : Controller
    {
        public IActionResult Index()
        {
            return View(
                new BuiltInTagHelpersIndexViewModel()
                {
                    Header = "Built-In Tag Helper Examples",
                    TagHelperLinks = new ActionLink[]
                    {
                        new ActionLink()
                        {
                            Url = Url.Action(nameof(Index)),
                            Content = nameof(Index)
                        },
                        new ActionLink()
                        {
                            Url = Url.Action(nameof(LoginForm)),
                            Content = nameof(LoginForm)
                        },
                        new ActionLink()
                        {
                            Url = Url.Action(nameof(Input)),
                            Content = nameof(Input)
                        },
                        new ActionLink()
                        {
                            Url = Url.Action(nameof(Select)),
                            Content = nameof(Select)
                        }
                    }
                }
                );
        }
        
        [HttpGet]
        public IActionResult LoginForm(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult LoginForm(LogInViewModel logInViewModel, string returnUrl = null)
        {
            if (!ModelState.IsValid)
            {
                ViewData["ReturnUrl"] = returnUrl;
                
                return View(logInViewModel);
            }
            
            if (!string.IsNullOrEmpty(returnUrl))
                return Redirect(returnUrl);

            return RedirectToAction(nameof(LoginForm));
        }

        [HttpGet]
        public IActionResult Input()
        {
            return View(
                new InputTodoItemsViewModel()
                {
                    TodoItems = new TodoItemViewModel[]
                    {
                        new TodoItemViewModel()
                        {
                            Name = "To finish the ASP.NET Core study",
                            IsDone = false
                        },
                        new TodoItemViewModel()
                        {
                            Name = "To end the electronic document flow",
                            IsDone = false
                        },
                        new TodoItemViewModel()
                        {
                            Name = "To accumulate the phone's battery",
                            IsDone = true
                        }
                    }
                }
            );
        }

        [HttpPost]
        public IActionResult Input(InputTodoItemsViewModel inputTodoItemsViewModel)
        {
            if (!ModelState.IsValid)
                return View(inputTodoItemsViewModel);

            return View("SavedInput", inputTodoItemsViewModel);
        }

        [HttpGet]
        public IActionResult Select()
        {
            return View(
                new SelectTechStackViewModel()
                {
                    Title = "Choose a Technology Stack",
                    CurrentTechStack = "nodejs",
                    TechStackItems = new SelectListItem[]
                    {
                        new SelectListItem("C#/ASP.NET Core", "aspnetcsharp"),
                        new SelectListItem("PHP/Apache", "phpapache"),
                        new SelectListItem("Ruby On Rails", "ruby"),
                        new SelectListItem("JavaScript/Node.Js", "nodejs"),
                        new SelectListItem("Java/Spring/Hibernate", "java"),
                    }
                }
            );
        }

        [HttpPost]
        public IActionResult Select(SelectTechStackViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            return Content($"Choosed a technology stack: {viewModel.CurrentTechStack}");
        }
        
    }
}