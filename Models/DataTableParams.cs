namespace SSBlogs.Models
{
    public class DataTableParams
    {
        public int Draw { get; set; }
        public int Start { get; set; }
        public int Length { get; set; }
        public SearchParams? Search { get; set; }
        public List<OrderParams>? Order { get; set; }
        public List<ColumnParams>? Columns { get; set; }
    }

    public class SearchParams
    {
        public string? Value { get; set; }
    }

    public class OrderParams
    {
        public int Column { get; set; }
        public string? Dir { get; set; }
    }

    public class ColumnParams
    {
        public string? Data { get; set; }
    }

}
