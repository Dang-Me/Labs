﻿using Contracts;
using Entities.Models;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class WarehouseRepository : RepositoryBase<Warehouse>, IWarehouseRepository
    {
        public WarehouseRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }
        public IEnumerable<Warehouse> GetAllWarehouse(bool trackChanges) =>
       FindAll(trackChanges)
        .OrderBy(c => c.GoodName)
        .ToList();

        public Warehouse GetWarehouse(Guid warehouseId, bool trackChanges) 
            => FindByCondition(c => c.Id.Equals(warehouseId), trackChanges).SingleOrDefault();

        public void CreateWarehouse(Warehouse warehouse) => Create(warehouse);
        public IEnumerable<Warehouse> GetByIds(IEnumerable<Guid> ids, bool trackChanges) =>
        FindByCondition(x => ids.Contains(x.Id), trackChanges).ToList();

        public void DeleteWarehouse(Warehouse warehouse)
        {
            Delete(warehouse);
        }
        public async Task<IEnumerable<Warehouse>> GetAllWarehouseAsync(bool trackChanges)
        => await FindAll(trackChanges)
        .OrderBy(c => c.GoodName)
        .ToListAsync();
        public async Task<Warehouse> GetWarehouseAsync(Guid warehouseId, bool trackChanges) =>
        await FindByCondition(c => c.Id.Equals(warehouseId), trackChanges).SingleOrDefaultAsync();
        public async Task<IEnumerable<Warehouse>> GetByIdsAsync(IEnumerable<Guid> ids, bool
        trackChanges) =>
        await FindByCondition(x => ids.Contains(x.Id), trackChanges).ToListAsync();
    }

}