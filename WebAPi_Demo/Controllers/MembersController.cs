using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPi_Demo.Models;

namespace WebAPi_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        public MemberRepository members = new MemberRepository();

        [HttpGet]
        [Route("GetAllMembers")]
        public  List<Member>Get()
        {
            return members.GetMembers();

                    }

        [HttpGet]
        [Route("GetMemberById/{id}")]
        public Member GetMemberById(int id,string name)
        {
            return members.GetMember(id);
        }
        [Route("Member/Search")]
        public string SearchMembers(string Department, string Gender, string City)
        {
            return $"Return Employees with Department : {Department}, Gender : {Gender}, City : {City}";
        }
    }
}
