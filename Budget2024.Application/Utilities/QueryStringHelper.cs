using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget2024.Application.Utilities
{
    public static class QueryStringHelper
    {
        public static string BuildQueryString(
               Dictionary<string, string>? filters,
               Dictionary<string, string>? sortOrder,
               int pageNumber,
               int pageSize)
        {
            var queryParams = new List<string>();

            // Add filters to query string
            if (filters != null && filters.Any())
            {
                foreach (var filter in filters)
                {
                    queryParams.Add($"filters[{filter.Key}]={Uri.EscapeDataString(filter.Value)}");
                }
            }

            // Add sortOrder to query string
            if (sortOrder != null && sortOrder.Any())
            {
                foreach (var sort in sortOrder)
                {
                    queryParams.Add($"sortOrder[{sort.Key}]={Uri.EscapeDataString(sort.Value)}");
                }
            }

            // Add pagination parameters
            queryParams.Add($"pageNumber={pageNumber}");
            queryParams.Add($"pageSize={pageSize}");

            return queryParams.Any() ? "?" + string.Join("&", queryParams) : string.Empty;
        }
    }
}
