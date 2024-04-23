using Microsoft.AspNetCore.Mvc;
using StoreAPI.Data;
using StoreAPI.Models;

namespace StoreAPI.Controllers;

[ApiController]
[Route("api/[controller]")] // api/User
public class CategoryController : ControllerBase
{
    // สร้าง Object ของ ApplicationDbContext
    private readonly ApplicationDbContext _context;

    // IWebHostEnvironment คืออะไร
    // IWebHostEnvironment เป็นอินเทอร์เฟซใน ASP.NET Core ที่ใช้สำหรับดึงข้อมูลเกี่ยวกับสภาพแวดล้อมการโฮสต์เว็บแอปพลิเคชัน
    // ContentRootPath: เส้นทางไปยังโฟลเดอร์รากของเว็บแอปพลิเคชัน
    // WebRootPath: เส้นทางไปยังโฟลเดอร์ wwwroot ของเว็บแอปพลิเคชัน
    private readonly IWebHostEnvironment _env;

    // สร้าง Constructor รับค่า ApplicationDbContext
    public CategoryController(ApplicationDbContext context, IWebHostEnvironment env)
    {
        _context = context;
        _env = env;
    }


    // Get all  categories
    // GET: api/Catergory
    [HttpGet]
    public ActionResult<category> GetCategories()
    {
        // IEnumerable คืออะไร
        // IEnumerable เป็น interface ใน .NET Framework ที่ใช้แทน collection ของ object
        // interface นี้กำหนด method เพียงตัวเดียวคือ GetEnumerator()

        // วนซ้ำผ่าน collection โดยใช้ foreach
        // foreach (var user in _users)
        // {
        //     Console.WriteLine($"{user.Id} - {user.Username}");
        // }

        // return Ok(_categories);

        var categories = _context.categories.OrderByDescending(category => category.category_id).ToList();


        return Ok(categories);
    }

    // Get category by id
    // GET: api/category /{id}
    [HttpGet("{id}")]
    public ActionResult<category> GetCategory(int id)
    {
        // LINQ คืออะไร
        // Language-Integrated Query (LINQ) คือ ฟีเจอร์ใน .NET Framework ที่ใช้สำหรับ query ข้อมูลจาก collection ของ object
        // โดยใช้คำสั่งที่คล้ายกับ SQL แต่เขียนในรูปแบบของ C#
        // var category = _categories.Find(u => u.Id == id); // find user by 
        // if (category == null)
        // {
        //     return NotFound();
        // }
        // return Ok(category);
        return Ok("test get by id");
    }

    // Create new user
    // POST: api/User
    [HttpPost]
    public ActionResult<category> CreateCategory([FromBody] category category)
    {
        // _categories.Add(category);
        // return CreatedAtAction(nameof(GetCategory), new { id = category.Id }, category);
        return Ok("test create");
    }

    // Update user by id
    // PUT: api/User/{id}
    [HttpPut("{id}")]
    public IActionResult UpdateCategory(int id, [FromBody] category category) {

        // //Validate user id
        // if (id != category.Id) {
        //     return BadRequest();
        // }

        // // Find existing user
        // var existingCategory = _catergories.Find(u => u.Id == id);
        // if (existingCategory  == null) {
        //     return NotFound();
        // }

        // // Update user
        // existingUser.Username = user.Username;
        // existingUser.Email = user.Email;
        // existingUser.Fullname = user.Fullname;

        // // Return updated user
        // return Ok(existingUser);
        return Ok("test update");
    }

    // Delete user by id
    // DELETE: api/User/{id}
    [HttpDelete("{id}")]
    public ActionResult DeleteUser(int id)
    {
        // var user = _users.Find(u => u.Id == id);
        // if (user == null)
        // {
        //     return NotFound();
        // }

        // _users.Remove(user);
        // return NoContent();
        return Ok("test delete"); 
    }


}

