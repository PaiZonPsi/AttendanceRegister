﻿using Domain.Common;

namespace Application.Interfaces.Repository;

public interface IRepository<TEntity> where TEntity : BaseEntity
{
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<TEntity?> GetByIdAsync(int id);
    Task CreateAsync(TEntity entity);
    void UpdateEntity(TEntity entity);
    Task<bool> SaveChangesAsync();
}