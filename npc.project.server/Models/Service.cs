namespace npc.project.server.Models
{
    public class Service
    {
        public class TableRow
        {
            public int SrNo { get; set; }
            public string ProjectTitle { get; set; } = string.Empty;
            public string TypeOfStudy { get; set; } = string.Empty;
            public string ClientName { get; set; } = string.Empty;
            public string ClientType { get; set; } = string.Empty;
            public string YearOfStudy { get; set; } = string.Empty;
            public string NameOfGroup { get; set; } = string.Empty;
            public string Area { get; set; } = string.Empty;
            public string Scope { get; set; } = string.Empty;
        }

        public class Table
        {
            public string Title { get; set; } = string.Empty;
            public List<TableRow> Row { get; set; }
        }
        public class PagedResponse<T>
        {
            public List<T> Data { get; set; } = new();
            public int TotalCount { get; set; }
        }

        public class TableReq
        {
            public string? Search { get; set; } = string.Empty;
            public int Page { get; set; }
            public int PageSize { get; set; }
        }
    }
}
