﻿using TaskManagement.Domain.Repositories.IBase;
using Task = TaskManagement.Domain.Entities.Task;

namespace TaskManagement.Domain.Repositories
{
    public interface ITaskRepository: IBaseBasicRepository<Task>
    {
        #region Domain-Specific interface


        #endregion
    }
}
