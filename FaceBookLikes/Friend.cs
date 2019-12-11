using System;

namespace FaceBookLikes
{
    public class Friend
    {
        private string Name;
        private Byte Age;
        public Friend(string name, byte age)
        {
            Name = name;
            Age = age;
        }

        public string Info()
        {
            return $"Name {Name}, Age {Age}";
        }
    }
}