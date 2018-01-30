using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Forest.Data;

namespace Forest.Controllers
{
    public class MusicAdminController : ApplicationController
    {
        //private Services.IService.IMusicService _musicService;

        public MusicAdminController()
        {
            //_musicService = new Services.Service.MusicService();
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
        [HttpGet]
        public ActionResult AddMusicRecording(string selectedGenre)
        {
            List<SelectListItem> genreList = new List<SelectListItem>();
            foreach(var item in _musicService.GetMusicCategories())
            {
                genreList.Add(
                  new SelectListItem()
                  {
                      Text = item.Genre,
                      Value = item.Id.ToString(),
                      Selected = (item.Genre == (selectedGenre) ? true : false)



                  });
            }

            ViewBag.genreList = genreList;
            return View();
        }

        // POST: MusicAdmin/Create
        [HttpPost]
        public ActionResult AddMusicRecording(Music_Recording recording)
        {
            try
            {
                // TODO: Add insert logic here
                _musicService.AddMusicRecording(recording);
                return RedirectToAction("Recordings", new { genre = recording.Genre, controller = "Music" });
            }
            catch
            {
                return View();
            }
        }



        // GET: MusicAdmin/Create
        [HttpGet]
        public ActionResult AddMusicGenre()
        {
            return View();
        }

        // POST: MusicAdmin/Create
        [HttpPost]
        public ActionResult AddMusicGenre(Music_Category category)
        {
            try
            {
                // TODO: Add insert logic here
                _musicService.AddMusicGenre(category);
                return RedirectToAction("Categories", new {controller = "Music" });
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


                //return RedirectToAction("Recordings", new { genre = recording.Genre, controller = "Music" });
                //return View_musicService.GetMusicCategories());

            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult EditMusicCategory(int id)
        {
            return View("EditMusicCategory", _musicService.GetMusicCategory(id));

        }

        // POST: MusicAdmin/Edit/5
        [HttpPost]
        public ActionResult EditMusicCategory(int id, Music_Category category)
        {
            try
            {
                // TODO: Add update logic here

                _musicService.EditMusicGenre(category);
                return RedirectToAction("Categories", new { genre = category.Genre, controller = "Music" });
                ;
            }
            catch
            {
                return View();
            }
        }


        // GET: MusicAdmin/Delete/5
        [HttpGet]
        public ActionResult DeleteMusicRecording(int id)
        {
            return View("DeleteMusicRecording", _musicService.GetMusicRecording(id));
        }

        // POST: MusicAdmin/Delete/5
        [HttpPost]
        public ActionResult DeleteMusicRecording(int id, Music_Recording recording)
        {
            try
            {
                Music_Recording _recording;
                _recording = _musicService.GetMusicRecording(recording.Id);
                _musicService.DeleteMusicRecording(_recording);
                return RedirectToAction("Recordings", new { genre = _recording.Genre, controller = "Music" });


                // TODO: Add delete logic here


            }
            catch
            {
                return View();
            }
        }

        // GET: MusicAdmin/Delete/5
        [HttpGet]
        public ActionResult DeleteMusicGenre(int id)
        {
            return View("DeleteMusicGenre", _musicService.GetMusicCategory(id));
        }

        // POST: MusicAdmin/Delete/5
        [HttpPost]
        public ActionResult DeleteMusicGenre(int id, Music_Category category)
        {

            // TODO: Add delete logic here
            try
            {
                Music_Category _category;
                _category = _musicService.GetMusicCategory(category.Id);
                _musicService.DeleteMusicGenre(_category);
                return RedirectToAction("Categories", new { genre = _category.Genre, controller = "Music" });

                //return RedirectToAction("Recordings", new { genre = _recording.Genre, controller = "Music" });
                
            }
            catch
            {
                return View();
            }
        }
    }
}
