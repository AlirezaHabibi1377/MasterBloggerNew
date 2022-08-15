using System.Collections.Generic;
using _01_Framework.Infrastructure;

namespace MB.Domain.ArticleCategoryAgg
{
    public interface IArticleCategoryRepository /*: IRepository<long, ArticleCategory>*/
    {
        List<ArticleCategory> GetAll();
        ArticleCategory Get(long Id);
        void Add(ArticleCategory entity);
        void Save();
        bool Exists(string title);
    }
}