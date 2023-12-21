namespace WebAPi_Demo.Models
{
    public class MemberRepository : IMemberRepository
    {

        List<Member> memberlist=new List<Member>
        {
            new Member{Id=1,FirstName="Bill",LastName="James",City="NewYork"},
            new Member{Id=2,FirstName="Mill",LastName="James",City="Mumbai"},
            new Member{Id=3,FirstName="Jill",LastName="James",City="Pune"},
            new Member{Id=4,FirstName="Till",LastName="James",City="London"},
            new Member{Id=5,FirstName="Nill",LastName="James",City="Banglore"},
            new Member{Id=6,FirstName="Gill",LastName="James",City="NewYork"},
        };
                public List<Member> GetMembers()
        {
            return memberlist;
        }
                public Member GetMember(int id)
        {
            return (Member)memberlist[id];
        }
    }
}
