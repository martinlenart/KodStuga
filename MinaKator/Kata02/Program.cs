namespace Kata05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a couple of members");
            IMember member1 = Member.Factory.CreateRandom();
            Console.WriteLine($"member1: {member1}");
            IMember member2 = Member.Factory.CreateRandom();
            Console.WriteLine($"member2: {member2}");

            IMember member3 = new Member(member1);
            Console.WriteLine($"member3: {member3}");

            Console.WriteLine("\nCreate a 20 Hilton members");
            MemberList HiltonMembers = MemberList.Factory.CreateRandom(20);
            HiltonMembers.Sort();
            Console.WriteLine(HiltonMembers);
            Console.WriteLine(HiltonMembers[10]);

            IMemberList copyList = new MemberList(HiltonMembers);
            Console.WriteLine(copyList);
            Console.WriteLine(copyList[10]);


        }
    }
}