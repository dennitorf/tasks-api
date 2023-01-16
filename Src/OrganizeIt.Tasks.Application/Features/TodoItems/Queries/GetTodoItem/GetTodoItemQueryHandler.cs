using AutoMapper;
using OrganizeIt.Tasks.Application.Common.Exceptions;
using OrganizeIt.Tasks.Application.Features.TodoItems.Queries.GetAllTodoItems;
using OrganizeIt.Tasks.Persistence.Contexts;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace OrganizeIt.Tasks.Application.Features.TodoItems.Queries.GetTodoItem
{
    public class GetTodoItemQueryHandler : IRequestHandler<GetTodoItemQuery, TodoItemDto>
    {
        private ILogger logger;
        private AppDbContext db;
        private IMapper mapper;

        public GetTodoItemQueryHandler(ILogger<GetTodoItemQueryHandler> logger, AppDbContext db, IMapper mapper)
        {
            this.logger = logger;
            this.db = db;
            this.mapper = mapper;
        }

        public async Task<TodoItemDto> Handle(GetTodoItemQuery request, CancellationToken cancellationToken)
        {
            var ent = await db.TodoItems.FindAsync(request.Id);

            if (ent == null)
                throw new NotFoundException(nameof(TodoItemDto), request.Id);

            return mapper.Map<TodoItemDto>(ent);
        }
    }
}
