using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterM
{
    public class PaginatedList<T> : List<T>
    {
        public int PageIndex { get; private set; } //頁次
        public int TotalPages { get; private set; } //總頁數

        
        public PaginatedList(List<T> items, int count, int pageIndex,
          int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            this.AddRange(items);
        }
        public bool HasPreviousPage { get { return (PageIndex > 1); } } //是否有前一頁
        public bool HasNextPage { get { return (PageIndex < TotalPages); } }//是否有下一頁
        public static async Task<PaginatedList<T>> CreateAsync(
            IQueryable<T> source, int pageIndex, int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageIndex - 1) * pageSize) //產生指定頁次的資料
              .Take(pageSize).ToListAsync();
            return new PaginatedList<T>(items, count, pageIndex, pageSize);
        }
    }

}
