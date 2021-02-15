using System;
using System.Collections.Generic;

namespace vscode_webapi
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
    }
}