using CollatzLW.Models;
using Microsoft.AspNetCore.Mvc;

namespace CollatzLW.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult About() { return View(); }
        public IActionResult Index()
        {
            return View(new IndexViewModel { Sequence = new List<long>() });
        }
        [HttpPost]
        public IActionResult Index(IndexViewModel indexView)
        {
            ViewBag.ValidationSummary = "";
            indexView.Sequence = new List<long>();
            if (indexView.Number > 0)
            {
                List<long> col = Collatz(indexView.Number);
                ViewBag.Steps = col.Count() - 1;
                string s = "";
                foreach (var item in col)
                {
                    s += item + ", ";
                }
                ViewBag.Sequence = s;
                ViewBag.Max = col.Max();
            }
            else
            {
                ViewBag.ValidationSummary = "O numero digitado deve ser maior que 0!";
            }

            return View(indexView);
        }
        private List<long> Collatz(long n)
        {
            List<long> data = new List<long>();
            data.Add(n);

            long resul = 0;

            while (true)
            {

                if (n == 1)
                {
                    break;
                }
                if ((n % 2) == 0)
                {
                    resul = n / 2;
                    n = resul;

                }
                else
                {
                    resul = (n * 3) + 1;
                    n = resul;
                }
                data.Add(n);
            }

            return data;
        }
    }
}