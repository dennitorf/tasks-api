using OrganizeIt.Tasks.Application.Features.Todos.Queries.GetAllTodos;
using MediatR;

namespace OrganizeIt.Tasks.Application.Features.Todos.Queries.GetTodo
{
    public class GetTodoQuery : IRequest<TodoDto>
    {
        public int Id { set; get; }
    }
}
