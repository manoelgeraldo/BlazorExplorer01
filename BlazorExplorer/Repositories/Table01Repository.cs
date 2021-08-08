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

        public async Task<Table01> GetById(int Id)
        {
            var verificaTable01 = await context.Table01s.SingleOrDefaultAsync(t => t.Id == Id);
            return verificaTable01;
        }

        public async Task<Table01> AddTable01(Table01 table01)
        {
            if(table01.Id == 0)
            {
                await context.Table01s.AddAsync(table01);
            }
            context.Table01s.Update(table01);
            
            await context.SaveChangesAsync();
            return table01;
        }

        public async Task<Table01> DeleteTable01(int Id)
        {
            var verificaTable01 = await context.Table01s.SingleOrDefaultAsync(t => t.Id == Id);

            if(verificaTable01 != null)
            {
                context.Table01s.Remove(verificaTable01);
                await context.SaveChangesAsync();
            }
            return verificaTable01;
        }
    }
}
