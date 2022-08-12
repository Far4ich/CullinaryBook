namespace Domain.Tag
{
    public interface ITagRepository
    {
        Tag GetById(int id);
        void Create(Tag tag);
    }
}
