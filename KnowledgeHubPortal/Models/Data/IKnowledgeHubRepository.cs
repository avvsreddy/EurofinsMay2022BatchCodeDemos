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

        void SaveCatagory(Catagory catagoryToSave);
        List<Catagory> GetCatagories();

        void DeleteCatagory(int id);

        void EditCatagory(Catagory catagoryToEdit);

    }
}
