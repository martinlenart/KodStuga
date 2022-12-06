using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata05
{
    public class Member : IMember
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public MemberLevel Level { get; set; }
        public DateTime Since { get; set; }

        public override string ToString() => $"{FirstName} {LastName} is a {Level} member since {Since.Year}";

        public int CompareTo(IMember? other)
        {
            if (this.Level != other.Level)
                return this.Level.CompareTo(other.Level);

            if (LastName != other.LastName)
                return LastName.CompareTo(other.LastName);

            if (FirstName != other.FirstName)
                return FirstName.CompareTo(other.FirstName);
            
            return Since.CompareTo(other.Since);

        }

        public bool Equals(IMember? other) => (LastName, FirstName, Level, Since) ==
                (other.LastName, other.FirstName, other.Level, other.Since);
        public override bool Equals(object obj) => Equals(obj as IMember);
        public override int GetHashCode() => (LastName, FirstName, Level, Since).GetHashCode();

        public static class Factory
        {
            public static Member CreateRandom()
            {
                var rnd = new Random();
                while (true)
                {
                    try
                    {
                        int year = rnd.Next(1980, DateTime.Today.Year + 1);
                        int month = rnd.Next(1, 13);
                        int day = rnd.Next(1, 32);

                        var Since = new DateTime(year, month, day);
                        
                        
                        var Level = (MemberLevel)rnd.Next((int)MemberLevel.Platinum, (int)MemberLevel.Blue + 1);

                        string[] _firstnames = "Fred John Mary Jane Oliver Marie".Split(' ');
                        string[] _lastnames = "Johnsson Pearsson Smith Ewans Andersson".Split(' ');
                        var FirstName = _firstnames[rnd.Next(0, _firstnames.Length)];
                        var LastName = _lastnames[rnd.Next(0, _lastnames.Length)];

                        var member = new Member { FirstName = FirstName, LastName = LastName, Level = Level, Since = Since };
                        return member;
                    }
                    catch { }
                }

            }
        }


        public Member()
        {

        }


        //Copy constructor for deep copy
        public Member(IMember other)
        {
            FirstName= other.FirstName;
            LastName= other.LastName;
            Level = other.Level;
            Since= other.Since;
        }
    }
}
