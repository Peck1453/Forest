using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Forest.Controllers;

namespace Forest.Controllers
{
    public abstract class ApplicationController : Controller
    {
        // GET: Application
        public Forest.Services.Service.MusicService _musicService;

        public ApplicationController()

        {
            _musicService = new Forest.Services.Service.MusicService();
            ViewBag.genres = _musicService.GetMusicCategories();

        }
    }
}