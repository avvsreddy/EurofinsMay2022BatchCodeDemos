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
        public void DeleteCatagory(int id)
        {
            throw new NotImplementedException();
        }

        public void EditCatagory(Catagory catagoryToEdit)
        {
            throw new NotImplementedException();
        }

        public List<Catagory> GetCatagories()
        {
            return db.Catagories.ToList();
        }

        public void SaveCatagory(Catagory catagoryToSave)
        {
            db.Catagories.Add(catagoryToSave);
            db.SaveChanges();
        }
    }
}