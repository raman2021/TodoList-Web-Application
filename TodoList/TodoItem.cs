using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// created new class to the root of project
namespace TodoList
{
    // it will contain 2 strings to public properties of title and a bollean IsDone
    public class TodoItem
    {
        public string Title { get; set; }
// for checkbox if the task is done
        public bool IsDone { get; set; }
    }
}
