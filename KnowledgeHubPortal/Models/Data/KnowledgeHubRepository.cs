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
            db.Catagories.Remove(db.Catagories.Find(id));
            db.SaveChanges();
        }

        public void EditCatagory(Catagory catagoryToEdit)
        {
            db.Entry(catagoryToEdit).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public List<Catagory> GetCatagories()
        {
            return db.Catagories.ToList();
        }

        public Catagory GetCatagory(int id)
        {
            return db.Catagories.Find(id);
        }

        public void SaveCatagory(Catagory catagoryToSave)
        {
            db.Catagories.Add(catagoryToSave);
            db.SaveChanges();
        }
    }
}