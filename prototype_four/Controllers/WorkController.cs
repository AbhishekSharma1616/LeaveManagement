using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prototype_four.Models;
using prototype_four.ViewModels;

namespace prototype_four.Controllers
{
    public class WorkController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public WorkController()
        {
            this._dbContext = new ApplicationDbContext();
        }
        // GET: Employee  
        [Authorize]
        public ActionResult Index()
        {
            
            var workList = this._dbContext.Work.Include(x => x.TaskTeam).ToList();
            return View(workList);
        }

        public ActionResult AddWorks()
        {
            var workViewModel = new WorkViewModel()
            {
                Team = this._dbContext.Team.ToList(),
                Work= new Work()
            };
            return View("WorkForm", workViewModel);
        }
        
        public ActionResult Edit(int id)
        {
            var works = this._dbContext.Work.FirstOrDefault(x => x.TeamId == id);
            var Team = this._dbContext.Team.ToList();

            var viewModel = new WorkViewModel()
            {
                Team = Team,
                Work = works
            };
            return View("WorkForm", viewModel);
        }
        

        [HttpPost]
        public ActionResult Save(Work work)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("AddWorks", "Work");
            }

            if (work.WorkId == 0)
                this._dbContext.Work.Add(work);

            else
            {
                var workDb = this._dbContext.Work.FirstOrDefault(x => x.WorkId == work.WorkId);
                workDb.WorkName = work.WorkName;
                workDb.Description = work.Description;
                workDb.TeamId = work.TeamId;
            }

            this._dbContext.SaveChanges();
            return RedirectToAction("Index", "Work");
        }

        public ActionResult Delete(int id)
        {
            var workDb = this._dbContext.Work.FirstOrDefault(x => x.WorkId == id);
            this._dbContext.Work.Remove(workDb);
            this._dbContext.SaveChanges();

            return RedirectToAction("Index", "Work");
        }
    }
}