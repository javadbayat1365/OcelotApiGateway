namespace Writer.Api.Repositories
{
    public interface IWriterRepository
    {
        Models.Writer? Get(int id);
        List<Models.Writer> GetAll();
        Models.Writer Insert(Models.Writer writer);
    }
}