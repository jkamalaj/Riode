using Microsoft.EntityFrameworkCore;
using Riode.Models;
namespace Riode.ViewModels
{
    internal class HomeVM
    {
        public IEnumerable<Slider>? Sliders { get;  set; }
        public IEnumerable<Service>? Services { get;  set; }
        public IEnumerable<Category>? Categories { get; set; }
        public IEnumerable<SaleNews>? News { get; set; }
        public IEnumerable<SeasonSale>? SeasonSales { get; set; }
        public IEnumerable<Product>? Products { get; set; }
        public IEnumerable<Badge>? Badges { get; set; }
    }
}