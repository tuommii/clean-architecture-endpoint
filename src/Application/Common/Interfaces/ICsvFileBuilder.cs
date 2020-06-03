using Sanoma.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace Sanoma.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
