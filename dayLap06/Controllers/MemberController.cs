using dayLap06.Models;
using Microsoft.AspNetCore.Mvc;

namespace dayLap06.Controllers
{
    public class MemberController : Controller
    {


        private static readonly List<Member> _listMember = new List<Member>()
        {
            new Member
        {
            MemberID = Guid.NewGuid().ToString(),
            MemberUserName = "nguyenvana",
            Password = "123456",
            Email = "nguyenvana@gmail.com",
            phone = "0335453654"
        },

        new Member
        {
            MemberID = Guid.NewGuid().ToString(),
            MemberUserName = "tranthib",
            Password = "123456",
            Email = "tranthib@gmail.com",
            phone = "0335453654"
        },

        new Member
        {
            MemberID = Guid.NewGuid().ToString(),
            MemberUserName = "levanc",
            Password = "123456",
            Email = "levanc@gmail.com",
            phone = "0335453654"
        },

        new Member
        {
            MemberID = Guid.NewGuid().ToString(),
            MemberUserName = "phamthid",
            Password = "123456",
            Email = "phamthid@gmail.com",
            phone = "0335453654"
        },

        new Member
        {
            MemberID = Guid.NewGuid().ToString(),
            MemberUserName = "hoangvane",
            Password = "123456",
            Email = "hoangvane@gmail.com",
            phone = "0335453654"
        }
        };
        public IActionResult Index()
        {
            return View(_listMember);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Member member)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(member);
                }

                member.MemberID = Guid.NewGuid().ToString();

                _listMember.Add(member);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            
        }

        public IActionResult Edit(string id)
        {
            Member member = _listMember.FirstOrDefault(m => m.MemberID == id);
            if( member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        [HttpPost]
        public IActionResult Edit(string id ,Member member)
        {

            Member _member = _listMember.FirstOrDefault(m => m.MemberID == id);

            _member.MemberUserName = member.MemberUserName;
            _member.Password = member.Password;
            _member.Email = member.Email;
            return RedirectToAction("Index");
        }

    }
}
