using System;
using System.Collections.Generic;

namespace BlazorApp1.Models
{
    public class PagedResult<T>
    {
        public List<T> Items { get; set; } = new List<T>();
        public int TotalCount { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public int TotalPages
        {
            get
            {
                if (PageSize == 0)
                    return 0;

                return (int)Math.Ceiling(TotalCount / (double)PageSize);
            }
        }
    }
}
