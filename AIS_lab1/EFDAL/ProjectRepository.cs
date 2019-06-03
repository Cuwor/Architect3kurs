using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace EFDAL
{
    public class ProjectRepository: IRepository<Project>
    {

        private AISContext _aisContext;

        public void Add(Project proj)
        {
            _aisContext.Projects.Add(proj);
        }

        public void Delete(Project proj)
        {
            _aisContext.Projects.Remove(proj);
        }

        public Project Get(int id)
        {
            return _aisContext.Projects.First(o => o.ID == id);
        }

        public ICollection<Project> GetAll()
        {
            return _aisContext.Projects.ToList();
        }

        public void Update(Project proj)
        {
            _aisContext.SaveChanges();
        }

        internal ProjectRepository(AISContext aisContext)
        {
            _aisContext = aisContext;
        }
    }
}
