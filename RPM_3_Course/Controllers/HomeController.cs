using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RPM_3_Course.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Hosting;

namespace RPM_3_Course.Controllers
{
    public class HomeController : Controller
    {

        private ApplicationContext db;
        private IHttpContextAccessor _httpContextAccessor;
        private IWebHostEnvironment _appEnvironment;

        public HomeController(ApplicationContext context, IHttpContextAccessor httpContextAccessor, IWebHostEnvironment appEnvironment)
        {
            db = context;
            _httpContextAccessor = httpContextAccessor;
            _appEnvironment = appEnvironment;
        }

        public async Task<IActionResult> Index(int? id, string email, int page = 1, SortState sortOrder = SortState.IdAsc)
        {
            IQueryable<User> users = db.Users;
            if (id != null && id > 0)
            {
                users = users.Where(p => p.Id == id);
            }
            if (!String.IsNullOrEmpty(email))
            {
                users = users.Where(p => p.Email.Contains(email));
            }
            //Сортировка
            switch (sortOrder)
            {
                case SortState.IdAsc:
                    {
                        users = users.OrderBy(p => p.Id);
                        break;
                    }
                case SortState.IdDesc:
                    {
                        users = users.OrderByDescending(p => p.Id);
                        break;
                    }
                case SortState.EmailAsc:
                    {
                        users = users.OrderBy(p => p.Email);
                        break;
                    }
                case SortState.EmailDesc:
                    {
                        users = users.OrderByDescending(p => p.Email);
                        break;
                    }
            }
        //Пагинация
             int pageSize = 5;
            var count = await users.CountAsync();
            var item = await users.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            IndexViewModel viewModel = new IndexViewModel
            {
                FilterViewModel = new FilterViewModel(id, email),
                SortViewModel = new SortViewModel(sortOrder),
                PageViewModel = new PageViewModel(count, page, pageSize),
                Users = item
            };
            return View(viewModel);
        }


        public async Task<IActionResult> IndexPicture(int? id, string email, int page = 1, SortState sortOrder = SortState.IdAsc)
        {
            IQueryable<Picturee> users = db.Picturee;
            //фильтрация или поиск
            if (id != null && id > 0)
            {
                users = users.Where(p => p.Id == id);
            }
            if (!String.IsNullOrEmpty(email))
            {
                users = users.Where(p => p.Name_Picture.Contains(email));
            }
            //Сортировка
            switch (sortOrder)
            {
                case SortState.IdAsc:
                    {
                        users = users.OrderBy(p => p.Id);
                        break;
                    }
                case SortState.IdDesc:
                    {
                        users = users.OrderByDescending(p => p.Id);
                        break;
                    }
                case SortState.EmailAsc:
                    {
                        users = users.OrderBy(p => p.Name_Picture);
                        break;
                    }
                case SortState.EmailDesc:
                    {
                        users = users.OrderByDescending(p => p.Name_Picture);
                        break;
                    }
            }
            //Пагинация
            int pageSize = 3;
            var count = await users.CountAsync();
            var item = await users.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            IndexPictureViewModel viewModel = new IndexPictureViewModel
            {
                FilterViewModel = new FilterViewModel(id, email),
                SortViewModel = new SortViewModel(sortOrder),
                PageViewModel = new PageViewModel(count, page, pageSize),
                Picturee = item
            };
            return View(viewModel);
        }


        public async Task<IActionResult> IndexPostPicture(int? id, string email, int page = 1, SortState sortOrder = SortState.IdAsc)
        {
            IQueryable<Pictureepost> users = db.Pictureepost; 
            //фильтрация или поиск
            if (id != null && id > 0)
            {
                users = users.Where(p => p.Id == id);
            }
            if (!String.IsNullOrEmpty(email))
            {
                users = users.Where(p => p.Name_Picture.Contains(email));
            }
            //Сортировка
            switch (sortOrder)
            {
                case SortState.IdAsc:
                    {
                        users = users.OrderBy(p => p.Id);
                        break;
                    }
                case SortState.IdDesc:
                    {
                        users = users.OrderByDescending(p => p.Id);
                        break;
                    }
                case SortState.EmailAsc:
                    {
                        users = users.OrderBy(p => p.Name_Picture);
                        break;
                    }
                case SortState.EmailDesc:
                    {
                        users = users.OrderByDescending(p => p.Name_Picture);
                        break;
                    }
            }
            //Пагинация
            int pageSize = 3;
            var count = await users.CountAsync();
            var item = await users.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            IndexPostPictureViewModel viewModel = new IndexPostPictureViewModel
            {
                FilterViewModel = new FilterViewModel(id, email),
                SortViewModel = new SortViewModel(sortOrder),
                PageViewModel = new PageViewModel(count, page, pageSize),
                Pictureepost = item
            };
            return View(viewModel);
        }


        public async Task<IActionResult> IndexPost(int? id, string email, int page = 1, SortState sortOrder = SortState.IdAsc)
        {
            IQueryable<Post> users = db.Posts;
            //фильтрация или поиск
            if (id != null && id > 0)
            {
                users = users.Where(p => p.Id == id);
            }
            if (!String.IsNullOrEmpty(email))
            {
                users = users.Where(p => p.Title.Contains(email));
            }
            //Сортировка
            switch (sortOrder)
            {
                case SortState.IdAsc:
                    {
                        users = users.OrderBy(p => p.Id);
                        break;
                    }
                case SortState.IdDesc:
                    {
                        users = users.OrderByDescending(p => p.Id);
                        break;
                    }
                case SortState.EmailAsc:
                    {
                        users = users.OrderBy(p => p.Title);
                        break;
                    }
                case SortState.EmailDesc:
                    {
                        users = users.OrderByDescending(p => p.Title);
                        break;
                    }
            }
            //Пагинация
            int pageSize = 3;
            var count = await users.CountAsync();
            var item = await users.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            IndexPostViewModel viewModel = new IndexPostViewModel
            {
                FilterViewModel = new FilterViewModel(id, email),
                SortViewModel = new SortViewModel(sortOrder),
                PageViewModel = new PageViewModel(count, page, pageSize),
                Post = item
            };
            return View(viewModel);
        }

        public static bool IsPost { get; }

        public IActionResult CreatePicture()
        {
            return View();
        }
        public IActionResult CreatePostPicture()
        {
            return View();
        }
        public IActionResult CreatePost()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreatePicture(Picturee user)
        {
            db.Picturee.Add(user);
            await db.SaveChangesAsync();
            return RedirectToAction("IndexPicture");
        }


        [HttpPost]
        public async Task<IActionResult> CreatePostPicture(Pictureepost user)
        {
            db.Pictureepost.Add(user);
            await db.SaveChangesAsync();
            return RedirectToAction("IndexPostPicture");
        }


        [HttpPost]
        public async Task<IActionResult> CreatePost(Post post)
        {
            db.Posts.Add(post);
            await db.SaveChangesAsync();
            return RedirectToAction("IndexPost");
        }


        public IActionResult Create()
        {
           
            return View();
        }

        public IActionResult PostView()
        {
            string cookieValue = _httpContextAccessor.HttpContext.Request.Cookies["user"];
            int ha = Convert.ToInt32(cookieValue);
            var players = db.Posts.Include(p => p.Pictureepost).Where(p => p.UserId == ha); ;
            return View(players.ToList());
        }

        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult PostCreate()
        {
            string cookieValue = _httpContextAccessor.HttpContext.Request.Cookies["user"];
            var max = db.Pictureepost.Max(i => i.Id);
            int postt = max + 1;
            ViewBag.MessagePost = postt;
            ViewBag.Date = Convert.ToString(DateTime.Now);
            ViewBag.Useriidd = Convert.ToInt32(cookieValue);
            return View();
        }

        public IActionResult Post()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            db.Users.Add(user);

            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Sign_In()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PostCreate(IFormFile uploadedFile, Post post)
        {

            bool yes = false;

            if (uploadedFile != null)
            {
                // путь к папке Files

                string path = "/imagespost/" + Path.GetFileName(uploadedFile.FileName);

                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);

                }
                //Добавление в БД
                Pictureepost file = new Pictureepost { Name_Picture = Path.GetFileName(uploadedFile.FileName), Path = path };
                db.Pictureepost.Add(file);
                db.SaveChanges();

                yes = true;

                if (yes == true)
                {
                    db.Posts.Add(post);
                    await db.SaveChangesAsync();
                }
               
            }
            return RedirectToAction("Profile");
    }

        [HttpGet]
        [ActionName("Delete")]
        public async Task<ActionResult> ConfimDelete(int? id)
        {
            if (id != null)
            {
                User user = await db.Users.FirstOrDefaultAsync(predicate => predicate.Id == id);
                if (user != null)
                {
                    return View(user);
                }
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> Delete(int? id)
        {
            if (id != null)
            {
                User user = await db.Users.FirstOrDefaultAsync(predicate => predicate.Id == id);
                if (user != null)
                {
                    db.Users.Remove(user);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");

                }
            }
            return NotFound();
        }

        [HttpGet]
        [ActionName("DeletePicture")]
        public async Task<ActionResult> ConfimDeletePicture(int? id)
        {
            if (id != null)
            {
                Picturee user = await db.Picturee.FirstOrDefaultAsync(predicate => predicate.Id == id);
                if (user != null)
                {
                    return View(user);
                }
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> DeletePicture(int? id)
        {
            if (id != null)
            {
                Picturee user = await db.Picturee.FirstOrDefaultAsync(predicate => predicate.Id == id);
                if (user != null)
                {
                    db.Picturee.Remove(user);
                    await db.SaveChangesAsync();
                    return RedirectToAction("IndexPicture");

                }
            }
            return NotFound();
        }


        [HttpGet]
        [ActionName("DeletePostPicture")]
        public async Task<ActionResult> ConfimDeletePostPicture(int? id)
        {
            if (id != null)
            {
                Pictureepost user = await db.Pictureepost.FirstOrDefaultAsync(predicate => predicate.Id == id);
                if (user != null)
                {
                    return View(user);
                }
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> DeletePostPicture(int? id)
        {
            if (id != null)
            {
                Pictureepost user = await db.Pictureepost.FirstOrDefaultAsync(predicate => predicate.Id == id);
                if (user != null)
                {
                    db.Pictureepost.Remove(user);
                    await db.SaveChangesAsync();
                    return RedirectToAction("IndexPostPicture");

                }
            }
            return NotFound();
        }


        [HttpGet]
        [ActionName("DeletePost")]
        public async Task<ActionResult> ConfimDeletePost(int? id)
        {
            if (id != null)
            {
            
                Post user = await db.Posts.FirstOrDefaultAsync(predicate => predicate.Id == id);
                if (user != null)
                {
                    return View(user);
                }
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> DeletePost(int? id)
        {
            if (id != null)
            {
                Post user = await db.Posts.FirstOrDefaultAsync(predicate => predicate.Id == id);
                if (user != null)
                {
                    db.Posts.Remove(user);
                    await db.SaveChangesAsync();
                    return RedirectToAction("IndexPost");

                }
            }
            return NotFound();
        }

        public async Task<ActionResult> EditPicture(int? id)
        {
            if (id != null)
            {
                Picturee user = await db.Picturee.FirstOrDefaultAsync(predicate => predicate.Id == id);
                if (user != null)
                {
                    return View(user);
                }
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> EditPicture(Picturee user)
        {
            db.Picturee.Update(user);
            await db.SaveChangesAsync();
            return RedirectToAction("IndexPicture");
        }


        public async Task<ActionResult> EditPostPicture(int? id)
        {
            if (id != null)
            {

                Pictureepost user = await db.Pictureepost.FirstOrDefaultAsync(predicate => predicate.Id == id);
                if (user != null)
                {
                    return View(user);
                }
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> EditPostPicture(Pictureepost user)
        {
            db.Pictureepost.Update(user);
            await db.SaveChangesAsync();
            return RedirectToAction("IndexPostPicture");
        }


        public async Task<ActionResult> EditPost(int? id)
        {
          
            if (id != null)
            {
                Post user = await db.Posts.FirstOrDefaultAsync(predicate => predicate.Id == id);
                if (user != null)
                {
                    return View(user);
                }
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> EditPost(Post post)
        {
            db.Posts.Update(post);
            await db.SaveChangesAsync();
            return RedirectToAction("IndexPost");
        }


        public async Task<ActionResult> Edit(int? id)
        {
            if (id != null)
            {
                User user = await db.Users.FirstOrDefaultAsync(predicate => predicate.Id == id);
                if (user != null)
                {
                    return View(user);
                }
            }
            return NotFound();
        }

        public async Task<ActionResult> EditUser(int? id)
        {
            if (id != null)
            {
                User user = await db.Users.FirstOrDefaultAsync(predicate => predicate.Id == id);
                if (user != null)
                {
                    return View(user);
                }
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(User user)
        {
            db.Users.Update(user);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(User user)
        {
            db.Users.Update(user);
            await db.SaveChangesAsync();
            return RedirectToAction("Profile");
        }

        [HttpPost]
        public async Task<IActionResult> Registration(User user, Roles roles)
        {

            bool Log1 = false;
            var users = db.Users.Where(p => EF.Functions.Like(p.Login, user.Login) && EF.Functions.Like(p.Email, user.Email));

            foreach (User user2 in users)
            {
                Log1 = true;
            }

            if (Log1 == true)
            {
                return RedirectToAction("Registration");
            }
            else
            {
                db.Users.Add(user);
                await db.SaveChangesAsync();
                return RedirectToAction("Sign_In");
            }

        }

        [HttpPost]
        public IActionResult Sign_In(User user)
        {
            int ff = 0;
            bool login1 = false;
            bool login2 = false;
            var users = db.Users.Where(p => EF.Functions.Like(p.Login, user.Login, user.Email) && EF.Functions.Like(p.Password, user.Password) && EF.Functions.Like(p.RolesId.ToString(), "1"));
            foreach (User user2 in users)
            {
                ff = user2.Id;
                login1 = true;
            }

            users = db.Users.Where(p => EF.Functions.Like(p.Login, user.Login, user.Email) && EF.Functions.Like(p.Password, user.Password) && EF.Functions.Like(p.RolesId.ToString(), "2"));

            foreach (User user2 in users)
            {
                ff = user2.Id;
                login2 = true;
            }

            CookieOptions cookie = new CookieOptions();
            cookie.Expires = DateTime.Now.AddMinutes(30);
            Response.Cookies.Append("user", ff.ToString(), cookie); //Создание Cookie-файла
            string cookieValue = _httpContextAccessor.HttpContext.Request.Cookies["user"];
            //return $"Вот данные: {cookieValue}";

            if (login1 == true)
            {
                return RedirectToAction("Index");
            }

            if (login2 == true)
            {
                return RedirectToAction("Profile");
            }

            else
                return View();

        }
        public async Task<ActionResult> Details(int? id)
        {

            if (id != null)
            {
                User user = await db.Users.FirstOrDefaultAsync(predicate => predicate.Id == id);
                if (user != null)
                {
                    return View(user);
                }
            }
            return NotFound();
        }

        public async Task<ActionResult> DetailsPicture(int? id)
        {
            if (id != null)
            {
                Picturee user = await db.Picturee.FirstOrDefaultAsync(predicate => predicate.Id == id);
                if (user != null)
                {
                    return View(user);
                }
            }
            return NotFound();
        }


        public async Task<ActionResult> DetailsPostPicture(int? id)
        {
            if (id != null)
            {
                Pictureepost user = await db.Pictureepost.FirstOrDefaultAsync(predicate => predicate.Id == id);
                if (user != null)
                {
                    return View(user);
                }
            }
            return NotFound();
        }

        public async Task<ActionResult> DetailsPost(int? id)
        {
            if (id != null)
            {
                Post user = await db.Posts.FirstOrDefaultAsync(predicate => predicate.Id == id);
                if (user != null)
                {
                    return View(user);
                }
            }
            return NotFound();
        }

        public async Task<ActionResult> Profile(int? id)
        {
            string cookieValue = _httpContextAccessor.HttpContext.Request.Cookies["user"];

            User user1 = db.Users.Find(Convert.ToInt32(cookieValue));
            int idpic = user1.PictureeId;

            Picturee picturee = db.Picturee.Find(idpic);
            string picpath = picturee.Path;

            ViewBag.Message = picpath;

            if (cookieValue != null)
            {
                User user = await db.Users.FirstOrDefaultAsync(predicate => predicate.Id == Convert.ToInt32(cookieValue));
                if (user != null)
                {
                    return View(user);
                }
            }
            return NotFound();
        }

        public IActionResult UploadImage()
        {
            return View(db.Picturee.ToList());
        }



        [HttpPost]
        public async Task<IActionResult> UploadImage(IFormFile uploadedFile, Picturee pict)
        {
            if (uploadedFile != null)
            {
                // путь к папке Files
                
                string path = "/images/" + Path.GetFileName(uploadedFile.FileName); ;

                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);

                }
                //Добавление в БД
                
                    Picturee file = new Picturee { Name_Picture = Path.GetFileName(uploadedFile.FileName), Path = path };
                    db.Picturee.Add(file);
                    db.SaveChanges();

                //Занаошу с помщью выборки и по айдишнками в таблицы
                string cookieValue = _httpContextAccessor.HttpContext.Request.Cookies["user"];
                var pi = db.Picturee.ToList();

                Picturee picturee = pi.LastOrDefault(p => p.Path == path);
                User user = db.Users.Find(Convert.ToInt32(cookieValue));
                user.PictureeId = picturee.Id;
                db.SaveChanges();
            }

            return RedirectToAction("Profile");
        }
        
               public async Task<ActionResult> DeleteUserPost(int? id)
                {
                    if (id != null)
                    {
                        Post user = await db.Posts.FirstOrDefaultAsync(predicate => predicate.Id == id);
                        if (user != null)
                        {
                            db.Posts.Remove(user);
                            await db.SaveChangesAsync();
                            return RedirectToAction("PostView");

                        }
                    }
                    return NotFound();
                }

        
        public async Task<ActionResult> EditUserPost(int? id)
        {
            if (id != null)
            {
                Post user = await db.Posts.FirstOrDefaultAsync(predicate => predicate.Id == id);
                if (user != null)
                {
                    ViewBag.Date = Convert.ToString(DateTime.Now);
                    return View(user);
                }
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> EditUserPost( Post post)
        {
           
            db.Posts.Update(post);
            await db.SaveChangesAsync();
            return RedirectToAction("PostView");
        }

        public async Task<IActionResult> PostsView(int? id)
        {
            IQueryable<Post> users = db.Posts;
            IQueryable<Pictureepost> users2 = db.Pictureepost;
            IQueryable<User> users3 = db.Users;
            var item = await users.ToListAsync();
            var item2 = await users2.ToListAsync();
            var item3 = await users3.ToListAsync();
            //ViewBag.Message = picpath;
            PostViewModel viewModel = new PostViewModel
            {
                posts = item,
                pictureeposts = item2,
                users = item3

            };
            return View(viewModel);
        }

        public async Task<ActionResult> OtherUser(int? id)
        {
         
            
                User user1 = db.Users.Find(id);
                int idpic = user1.PictureeId;

                Picturee picturee = db.Picturee.Find(idpic);
                string picpath = picturee.Path;

                ViewBag.Message = picpath;

                User user = await db.Users.FirstOrDefaultAsync(predicate => predicate.Id == id);
                if (user != null)
                {
                    return View(user);
                  
                }
            
            

            return NotFound();
        }


        public IActionResult PostOtherUserView(int? id)
        {
            var players = db.Posts.Include(p => p.Pictureepost).Where(p => p.UserId == id);
            return View(players.ToList());

        }



    }
}

