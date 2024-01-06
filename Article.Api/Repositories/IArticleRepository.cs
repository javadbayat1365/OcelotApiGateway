namespace Article.Api.Repositories
{
    public interface IArticleRepository
    {
        int Delete(int id);
        Models.Article? Get(int id);
        List<Models.Article> GetAll();
    }
}