namespace npc.project.server.Models
{
    public class AboutUs
    {
        public class Member
        {
            public string Name { get; set; }
            public string Designation { get; set; }
            public string Telephone { get; set; }
            public string Mail { get; set; }
            public string Address { get; set; }
        }

        public class Table
        {
            public string Title { get; set; }
            public List<Member> Members { get; set; }
        }

    }
}
