using OrganizeIt.Tasks.Application.Features.Todos.Queries.GetAllTodos;
using MediatR;

namespace OrganizeIt.Tasks.Application.Features.Todos.Commands.CreateTodo
{
    public class CreateTodoCommand : IRequest<TodoDto>
    {
        public string Name { set; get; }
    }
}
