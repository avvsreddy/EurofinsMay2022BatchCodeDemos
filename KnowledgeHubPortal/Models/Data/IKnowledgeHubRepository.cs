using KnowledgeHubPortal.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeHubPortal.Models.Data
{
    public interface IKnowledgeHubRepository
    {
        #region Catagories
        void SaveCatagory(Catagory catagoryToSave);
        List<Catagory> GetCatagories();
        Catagory GetCatagory(int id);

        void DeleteCatagory(int id);

        void EditCatagory(Catagory catagoryToEdit);
        #endregion

        #region Articles

        void SubmitArticle(Article articleToSave);
        void ApproveArticles(List<int> articlesToApprove);

        void RejectArticles(List<int> articlesToReject);

        List<Article> GetNewArticlesByCatagory(int id);
        List<Article> GetApprovedArticlesByCatagory(int id);

        List<Article> GetApprovedArticles();
        List<Article> GetArticlesForApprove();



        #endregion
    }
}
