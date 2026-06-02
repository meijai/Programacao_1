using Model;
using Repository.VirtualDatabase;

namespace Repository
{
    public class CategoryRepository : BaseRepository<Category>
    {
        public List<Category> GetAll()
        {
            return MyData.Categories;
        }
    }
}
