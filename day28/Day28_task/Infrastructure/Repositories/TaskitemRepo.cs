using Infrastructure.Data.DbContexts;
using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class TaskitemRepo : ITaskitemRepo
    {
        AssessmentDbContext _context;
        public TaskitemRepo()
        {
            _context = new AssessmentDbContext();
        }

        public void Add(Taskitem taskitem)
        {
            _context.Add(taskitem);
        }
        public void Update(Taskitem taskitem)
        {
            _context.Update(taskitem);

        }
        public void Delete(Taskitem taskitem)
        {
            _context.Remove(taskitem);
        }

        public List<Taskitem> GetAll()
        {
            return _context.Tasks.ToList();
        }
        public Taskitem GetById(int id)
        {
            return _context.Tasks.FirstOrDefault(d => d.Id == id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
