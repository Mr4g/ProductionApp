﻿using ProductionApp.Entities;

namespace ProductionApp.Repositories;

public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T>
where T : class, IEntity
{

}