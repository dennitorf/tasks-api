using OrganizeIt.Tasks.Domain.Common;
using System.Collections.Generic;

namespace OrganizeIt.Tasks.Domain.Entities.Sample
{
    public class Todo : BaseEntity
    {
        public string Name { set; get; }        
        public virtual ICollection<TodoItem> TodoItems { get; set; }
    }
}
