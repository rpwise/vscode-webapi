using System;
using System.Collections.Generic;

namespace vscode_webapi
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public School School { get; set; }

        public ICollection<Class> Classes { get; set; }
    }
}