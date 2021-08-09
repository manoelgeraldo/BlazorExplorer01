using BlazorExplorer.Entities;
using BlazorExplorer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExplorer.Services
{
    public class Table01Service : ITable01Service
    {
        private readonly ITable01Repository table01Repository;

        public Table01Service(ITable01Repository table01Repository)
        {
            this.table01Repository = table01Repository;
        }

        public async Task<List<Table01>> GetAll()
        {
            return await table01Repository.GetAll();
        }

        public async Task<Table01> GetById(int id)
        {
            var verificaTable01 = await table01Repository.GetById(id);
            return verificaTable01;
        }

        public async Task<Table01> AddTable01(Table01 table01)
        {
            var novoTable01 = await table01Repository.AddTable01(table01);
            return novoTable01;
        }

        public async Task<Table01> DeleteTable01(int id)
        {
            var verificaTable01 = await table01Repository.DeleteTable01(id);
            return verificaTable01;
        }
    }
}
