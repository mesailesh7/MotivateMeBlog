using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MotivateMe.Data;
using MotivateMe.Models.ViewModels;

namespace MotivateMe.Controllers
{

    public class PostController : Controller
    {
        private readonly AppDbContext _context;
        private readonly string[] _allowedExtensions = {".jpg", ".jpeg", ".png"};
        private readonly IWebHostEnvironment _webHostEnvironment;
        
        public PostController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
            // GET
        [HttpGet]
        public IActionResult Create()
        {
            var postViewModel = new PostViewModel();
            postViewModel.Categories = _context.Categories.Select(c =>
            new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name,
            }            
            ).ToList();

            return View(postViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PostViewModel postViewModel)
        {
            if (ModelState.IsValid)
            {
                var inputFileExtension = Path.GetExtension(postViewModel.FeatureImage.FileName).ToLower();
                
                bool isAllowed =  _allowedExtensions.Contains(inputFileExtension);

                if (!isAllowed)
                {
                    ModelState.AddModelError("", "Invalid Image format. Allowed Format are .jpg .jpeg .png");
                    
                    return View(postViewModel);
                }

                postViewModel.Post.FeatureImagePath = await UploadFiletoFolder(postViewModel.FeatureImage);
                
                await _context.Posts.AddAsync(postViewModel.Post);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");




            }
            return View(postViewModel);
        }

        private async Task<string> UploadFiletoFolder(IFormFile file)
        {
            var inputFileExtension = Path.GetExtension(file.FileName);

            var fileName = Guid.NewGuid().ToString() + inputFileExtension;
            
            var wwwrootPath = _webHostEnvironment.WebRootPath;
            var imagesFolderPath = Path.Combine(wwwrootPath, "images");

            if (!Directory.Exists(imagesFolderPath))
            {
                Directory.CreateDirectory(imagesFolderPath);
            }
            
            var filePath = Path.Combine(imagesFolderPath, fileName);
            try
            {
                await using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                    
                }
            }
            catch (Exception ex)
            {
                return "Error upload images: " + ex.Message;
            }
            
            return "/images/" + fileName;
            
            
            

        }
    }
}