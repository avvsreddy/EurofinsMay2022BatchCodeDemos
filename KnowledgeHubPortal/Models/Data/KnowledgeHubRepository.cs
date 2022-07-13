using KnowledgeHubPortal.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnowledgeHubPortal.Models.Data
{
    public class KnowledgeHubRepository : IKnowledgeHubRepository
    {

        private KnowledgeHubDbContext db = new KnowledgeHubDbContext();

        public void ApproveArticles(List<int> articlesToApprove)
        {
            foreach (int id in articlesToApprove)
            {
                var article = db.Articles.Find(id);
                if(article != null)
                {
                    article.IsApproved = true;
                }
            }
            db.SaveChanges();
        }

        #region Catagories
        public void DeleteCatagory(int id)
        {
            db.Catagories.Remove(db.Catagories.Find(id));
            db.SaveChanges();
        }

        public void EditCatagory(Catagory catagoryToEdit)
        {
            db.Entry(catagoryToEdit).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public List<Article> GetApprovedArticles()
        {
            throw new NotImplementedException();
        }

        public List<Article> GetApprovedArticlesByCatagory(int id)
        {
            throw new NotImplementedException();
        }

        public List<Article> GetArticlesForApprove()
        {
            throw new NotImplementedException();
        }

        public List<Catagory> GetCatagories()
        {
            return db.Catagories.ToList();
        }

        public Catagory GetCatagory(int id)
        {
            return db.Catagories.Find(id);
        }

        public List<Article> GetNewArticlesByCatagory(int id)
        {
            throw new NotImplementedException();
        }

        public void RejectArticles(List<int> articlesToReject)
        {
            throw new NotImplementedException();
        }

        public void SaveCatagory(Catagory catagoryToSave)
        {
            db.Catagories.Add(catagoryToSave);
            db.SaveChanges();
        }

        public void SubmitArticle(Article articleToSave)
        {
            db.Articles.Add(articleToSave);
            db.SaveChanges();
        }
        #endregion

        #region Articles


        #endregion
    }
}