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
            Email = "nguyenvana@gmail.com"
        },

        new Member
        {
            MemberID = Guid.NewGuid().ToString(),
            MemberUserName = "tranthib",
            Password = "123456",
            Email = "tranthib@gmail.com"
        },

        new Member
        {
            MemberID = Guid.NewGuid().ToString(),
            MemberUserName = "levanc",
            Password = "123456",
            Email = "levanc@gmail.com"
        },

        new Member
        {
            MemberID = Guid.NewGuid().ToString(),
            MemberUserName = "phamthid",
            Password = "123456",
            Email = "phamthid@gmail.com"
        },

        new Member
        {
            MemberID = Guid.NewGuid().ToString(),
            MemberUserName = "hoangvane",
            Password = "123456",
            Email = "hoangvane@gmail.com"
        }
        };
        public IActionResult Index()
        {
            return View(_listMember);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Member member)
        {
            member.MemberID = Guid.NewGuid().ToString();
            _listMember.Add(member);
            return RedirectToAction("Index");
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
