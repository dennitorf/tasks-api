using OrganizeIt.Tasks.Application.Common.Interfaces.Mappings;
using OrganizeIt.Tasks.Domain.Entities.Sample;
using System;

namespace OrganizeIt.Tasks.Application.Features.Todos.Queries.GetAllTodos
{
    public class TodoDto : IMapFrom<Todo>
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public bool IsActive { set; get; }
    }
}