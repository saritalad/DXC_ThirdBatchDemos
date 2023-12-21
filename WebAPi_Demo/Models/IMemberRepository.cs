namespace WebAPi_Demo.Models
{
    public interface IMemberRepository
    {
        public List<Member> GetMembers();
        public Member GetMember(int id);
    }
}
