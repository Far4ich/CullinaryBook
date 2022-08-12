using Domain.Tag;

namespace Infrastructure.Data.TagModel
{
    public class TagRepository : ITagRepository
    {
        private readonly CullinaryBookContext _dbContext;

        public TagRepository(CullinaryBookContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Create(Tag tag)
        {
            throw new NotImplementedException();
        }

        public Tag GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
