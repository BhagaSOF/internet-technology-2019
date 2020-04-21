using System.Collections.Generic;

namespace Webapp.Helpers
{
    public class PagedData<T> where T : class
    {
        public IEnumerable<T> Data { get; set; }
        public int TotalPages { get; set; }

        public int CurrentPage { get; set; }
    }
}