using BlazorExplorer.Data;
using BlazorExplorer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExplorer.Repositories
{
    public class Table01Repository : ITable01Repository
    {
        private readonly BlazorExplorerContext context;

        public Table01Repository(BlazorExplorerContext context)
        {
            this.context = context;
        }

        public async Task<List<Table01>> GetAll()
        {
            return await context.Table01s.AsNoTracking()
                                         .Include(t => t.Table02)
                                         .ToListAsync();
        }

        public async Task<Table01> AddTable01(Table01 table01)
        {
            await context.Table01s.AddAsync(table01);
            await context.SaveChangesAsync();
            return table01;
        }
    }
}
