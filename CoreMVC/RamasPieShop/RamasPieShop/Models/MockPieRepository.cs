using System;
using System.Collections.Generic;
using System.Linq;

namespace RamasPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> _pies;

        public MockPieRepository()
        {
            if (_pies == null)
            {
                InitializePies();
            }
        }

        private void InitializePies()
        {
            _pies = new List<Pie>
            {
                new Pie{Id=1, Name="Apple Pie", Price=12.95M, ShortDescription="Our famous apple pies!",LongDescription="Our famous apple pies!", ImageThumbnailUrl="/images/1.png",ImageUrl="https://openclipart.org/image/300px/svg_to_png/27070/egore911_saw.png"},
                  new Pie{Id=2, Name="Blue Cheese Cake", Price=12.95M, ShortDescription="Our famous apple pies!",LongDescription="Our famous apple pies!", ImageThumbnailUrl="/images/2.png",ImageUrl="https://openclipart.org/image/300px/svg_to_png/27070/egore911_saw.png"},
                    new Pie{Id=3, Name="Cheese Cake", Price=12.95M, ShortDescription="Our famous apple pies!",LongDescription="Our famous apple pies!", ImageThumbnailUrl="/images/3.png",ImageUrl="https://openclipart.org/image/300px/svg_to_png/27070/egore911_saw.png"},
                      new Pie{Id=4, Name="Cherry Pie", Price=12.95M, ShortDescription="Our famous apple pies!",LongDescription="Our famous apple pies!", ImageThumbnailUrl="/images/4.png",ImageUrl="https://openclipart.org/image/300px/svg_to_png/27070/egore911_saw.png"}
            };
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _pies.FirstOrDefault(p=> p.Id==pieId);
        }
    }
}
