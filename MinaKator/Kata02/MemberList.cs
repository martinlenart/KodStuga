using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata05
{
    public class MemberList : IMemberList
    {
        private List<IMember> _members = new List<IMember>();
        public IMember this[int idx] => _members[idx];

        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < _members.Count; i++)
            {
                sRet += $"{_members[i]}\n";
                if ((i + 1) % 10 == 0)
                {
                    sRet += "\n";
                }
            }
            return sRet;
        }

        public int Count() => _members.Count;
 
        public int Count(int year)
        {
            int c = 0;
            foreach (var item in _members)
            {
                if (item.Since.Year == year)
                    c++;
            }
            return c;
        }

        public void Sort() => _members.Sort();

        public static class Factory
        {
            public static MemberList CreateRandom(int NrOfItems)
            {
                var memberlist = new MemberList();
                for (int i = 0; i < NrOfItems; i++)
                {
                    memberlist._members.Add(Member.Factory.CreateRandom());
                }
                return memberlist;
            }
        }

        public MemberList()
        {

        }
        public MemberList(MemberList org)
        {
            //Shallow Copy
            _members = org._members;

            //Deep copy manual
            _members = new List<IMember>();
            foreach (var item in org._members)
            {
                _members.Add(new Member(item));
            }

            //Deep copy using Linq
            _members = org._members.Select(o => new Member(o)).ToList<IMember>();
        }
    }
}
