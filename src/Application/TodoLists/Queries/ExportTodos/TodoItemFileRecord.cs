using Sanoma.Application.Common.Mappings;
using Sanoma.Domain.Entities;

namespace Sanoma.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
