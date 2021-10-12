using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prototype_four.Models;
using prototype_four.Views.ViewModels;

namespace prototype_four.Controllers
{
    public class LeaveController : Controller
    {
        private readonly ApplicationDbContext _Context;
        public LeaveController()
        {
            _Context = new ApplicationDbContext();
        }
        [Authorize]
        public ActionResult Index()
        {
            var leaveList = this._Context.Leave.Include(x => x.LeaveType).ToList();
            return View(leaveList);
        }
        [Authorize]
        public ActionResult AddLeave()
        {
            var leaveViewModel = new LeaveViewModel()
            {
                LeaveType = this._Context.LeaveType.ToList(),
                Leave = new Leave()
            };
            return View("LeaveForm", leaveViewModel);
        }

        public ActionResult Save(Leave leave)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("AddLeaves", "Leave");
            }

            if (leave.LeaveId == 0)
                this._Context.Leave.Add(leave);

            else
            {
                
                var leavesDb = this._Context.Leave.FirstOrDefault(x => x.LeaveId == leave.LeaveId);
                leavesDb.LeaveDescription = leave.LeaveDescription;
                leavesDb.fromTo = leave.fromTo;
                leavesDb.Useremail = leave.Useremail;
                leavesDb.LeaveTypeId = leave.LeaveTypeId;
                
            }

            this._Context.SaveChanges();
            return RedirectToAction("Index", "Leave");
        }

        public ActionResult Delete(int id)
        {
            var leaveDb = this._Context.Leave.FirstOrDefault(x => x.LeaveId == id);
            this._Context.Leave.Remove(leaveDb);
            this._Context.SaveChanges();

            return RedirectToAction("Index", "Leave");
        }
        
        
        public ActionResult Approve(int id)
        {
            int value = 1;
            //var leavesDb = this._Context.Leave.FirstOrDefault(x => x.LeaveId == id);
            var db = new ApplicationDbContext();
            var enitiyItem = db.Leave.FirstOrDefault(s => s.LeaveId == id);
            if(enitiyItem != null)
            {
                enitiyItem.Checked = value;
            }
            db.Entry(enitiyItem).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index", "Leave");
        }
        public ActionResult Decline (int id)
        {
            int value = 2;
            //var leavesDb = this._Context.Leave.FirstOrDefault(x => x.LeaveId == id);
            var db = new ApplicationDbContext();
            var enitiyItem = db.Leave.FirstOrDefault(s => s.LeaveId == id);
            if (enitiyItem != null)
            {
                enitiyItem.Checked = value;
            }
            db.Entry(enitiyItem).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index", "Leave");
        }

        protected override void Dispose(bool disposing)
       {
            _Context.Dispose();
        }
        // GET: Leave
        
    }
}