using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBookLikes
{
    class Program
    {
        static void Main(string[] args)
        {
            var likes = new List<Friend>
            {
                new Friend("John", 22),
                new Friend("Mai", 22),
                new Friend("Julie", 22)
            };
            string result = "";
            for (int i = 0; i < Math.Min(likes.Count(), 3); i++)
            {
                if (i < 2) result += likes[i].Info() + " ";
                else result += $"and {likes.Count() - 2} others";
            }

            Console.WriteLine(result);
        }
    }
}
