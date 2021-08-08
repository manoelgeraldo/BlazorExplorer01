using BlazorExplorer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorExplorer.Services
{
    public interface ITable01Service
    {
        Task<Table01> AddTable01(Table01 table01);
        Task<Table01> DeleteTable01(int id);
        Task<List<Table01>> GetAll();
        Task<Table01> GetById(int id);
    }
}