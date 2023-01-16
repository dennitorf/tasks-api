using OrganizeIt.Tasks.Application.Features.TodoItems.Queries.GetAllTodoItems;
using MediatR;

namespace OrganizeIt.Tasks.Application.Features.TodoItems.Commands.CreateTodoItem
{
    public class CreateTodoItemCommand : IRequest<TodoItemDto>
    {
        public string Name { set; get; }
        public int TodoId { set; get; }
    }
}
