﻿﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GSAPP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace GSAPP.Controllers
{
    public class HomeController : Controller
    {

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private MyContext dbContext;

        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        private int? UserSession
        {
            get { return HttpContext.Session.GetInt32("UserId"); }
            set { HttpContext.Session.SetInt32("UserId", (int)value); }
        }



        // [HttpGet("together")]
        public IActionResult LandingPage()
        {
            return View();
        }

        [HttpGet("together/login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet("together/register")]
        public IActionResult Register()
        {
            // ViewBag.hasError = true;
            return View();
        }

        [HttpGet("together/dashboard")]
        public IActionResult Dashboard()
        {
            if (UserSession == null)
            {
                return RedirectToAction("LandingPage");
            }
            User CurrentUser = dbContext.Users.FirstOrDefault(a => a.UserId == UserSession);
            List<User> NearbyUsers = dbContext.Users.Include(a => a.RequestsCreated).Where(a => a.ZipCode == CurrentUser.ZipCode).ToList();
            return View(NearbyUsers);
        }

        [HttpGet("View/{Uid}/Details")]
        public IActionResult Detail(int Uid)
        {
            if (UserSession == null)
            {
                return RedirectToAction("LandingPage");
            }
            User DetailsFor = dbContext.Users.FirstOrDefault(q => q.UserId == Uid);
            return View(DetailsFor);
        }

        public IActionResult Form()
        {
            if (UserSession == null)
            {
                return RedirectToAction("LandingPage");
            }
            return View();
        }



        [HttpPost("together/register/new-user")]
        public IActionResult RegisterUser(User newUser)
        {
            if (ModelState.IsValid)
            {
                if (dbContext.Users.Any(i => i.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already exists!");
                    ViewBag.hasError = true;
                    return View("Register");
                }
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                string hashedPw = hasher.HashPassword(newUser, newUser.Password);
                newUser.Password = hashedPw;
                dbContext.Add(newUser);
                dbContext.SaveChanges();
                UserSession = newUser.UserId;
                if (newUser.Status == false)
                {
                    return RedirectToAction("Dashboard");
                }
                return RedirectToAction("Dashboard");
            }
            ViewBag.hasError = true;
            return View("Register");
        }

        [HttpPost("together/login/user")]
        public IActionResult LoginUser(Login currentUser)
        {
            if (ModelState.IsValid)
            {
                var UserInDb = dbContext.Users.FirstOrDefault(i => i.Email == currentUser.LoginEmail);
                if (UserInDb == null)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Credentials");
                    return View("Login");
                }
                var hasher = new PasswordHasher<Login>();
                var result = hasher.VerifyHashedPassword(currentUser, UserInDb.Password, currentUser.LoginPassword);
                if (result == 0)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Credentials");
                    return View("Login");
                }
                UserSession = UserInDb.UserId;
                return RedirectToAction("Dashboard");
            }
            return View("Login");
        }

        [HttpPost("together/request-help")]
        public IActionResult RequestHelp(Request newRequest)
        {
            if (ModelState.IsValid)
            {
                newRequest.UserID = (int)UserSession;
                dbContext.Add(newRequest);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            return View("RequestForm");
        }

    }
}
