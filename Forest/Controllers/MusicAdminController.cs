using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Forest.Data;

namespace Forest.Controllers
{
    public class MusicAdminController : Controller
    {
        private Services.IService.IMusicService _musicService;

        public MusicAdminController()
        {
            _musicService = new Services.Service.MusicService();
        }
        // GET: MusicAdmin

       
        

        public ActionResult Index()
        {
            return View();
        }

        // GET: MusicAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MusicAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MusicAdmin/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MusicAdmin/Edit/5

        [HttpGet]
        public ActionResult EditMusicRecording(int id)
        {
            return View("EditMusicRecording",_musicService.GetMusicRecording(id));

        }

        // POST: MusicAdmin/Edit/5
        [HttpPost]
        public ActionResult EditMusicRecording(int id, Music_Recording recording)
        {
            try
            {
                // TODO: Add update logic here

                _musicService.EditMusicRecording(recording);
                return RedirectToAction("Recordings", new { genre = recording.Genre, controller = "Music" });
            }
            catch
            {
                return View();
            }
        }

        // GET: MusicAdmin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MusicAdmin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
