using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asyvix.BlazorExample.SimpleTodo.Data
{
    public class TodoItem
    {
        public string Id { get; private set; } = Guid.NewGuid().ToString();
        public string Content { get; set; } = string.Empty;
        public bool IsComplete { get; set; } = false;
    }
}
