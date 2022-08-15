using System.Collections.Generic;
using _01_Framework.Infrastructure;
using MB.Application.Contracts.Article;

namespace MB.Domain.ArticleAgg
{
    public interface IArticleRepository/* : IRepository<long, Article>*/
    {
        void CreateAndSave(Article entity);
        List<ArticleViewModel> GetList();
        Article Get(long id);
        void Save();
        bool Exist(string title);
        //List<ArticleViewModel> GetList();
    }
}