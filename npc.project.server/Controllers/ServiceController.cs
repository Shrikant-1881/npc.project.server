using Microsoft.AspNetCore.Mvc;
using npc.project.server.Models;
using npc.project.server.Services;
using static npc.project.server.Models.Service;

namespace npc.project.server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController: Controller
    {
        private readonly ServiceService _service;
        public ServiceController(ServiceService service) {
            _service = service;
        }

        [HttpGet("getConsultancyProjects")]
        public IActionResult getConsultancyProjects([FromQuery]  TableReq request)
        {
            var tables = new List<Table>
            {
                new Table
                {
                    Title = "CONSULTANCY PROJECTS",
                    Row = new List<TableRow>
                    {
                        new TableRow
                        {
                            SrNo = 1,
                            ProjectTitle = "Water Balance Study",
                            TypeOfStudy = "",
                            ClientName = "NTPC-Karakka",
                            ClientType = "Central Government",
                            YearOfStudy = "2010-11",
                            NameOfGroup = "RD Kolkata",
                            Area = "Energy Management",
                            Scope = ""
                        },
                        new TableRow
                        {
                            SrNo = 2,
                            ProjectTitle = "Details Energy Audit",
                            TypeOfStudy = "",
                            ClientName = "MCC-PTA, Haldia",
                            ClientType = "Private Sector",
                            YearOfStudy = "2010-11",
                            NameOfGroup = "RD Kolkata",
                            Area = "Energy Management",
                            Scope = ""
                        },
                        new TableRow
                        {
                            SrNo = 3,
                            ProjectTitle = "Details Energy Audit",
                            TypeOfStudy = "",
                            ClientName = "Andrew Yule Tea State",
                            ClientType = "Private Sector",
                            YearOfStudy = "2010-11",
                            NameOfGroup = "RD Kolkata",
                            Area = "Energy Management",
                            Scope = ""
                        },
                        new TableRow
                        {
                            SrNo = 4,
                            ProjectTitle = "Insulation Survey Study",
                            TypeOfStudy = "",
                            ClientName = "Mangalore Chemical & Fertiliser",
                            ClientType = "Private Sector",
                            YearOfStudy = "2010-11",
                            NameOfGroup = "RD Kolkata",
                            Area = "Technology Management",
                            Scope = ""
                        },
                        new TableRow
                        {
                            SrNo = 5,
                            ProjectTitle = "Manpower Assessment Study",
                            TypeOfStudy = "",
                            ClientName = "Oil India Ltd, Kolkata Branch Office",
                            ClientType = "Central Government",
                            YearOfStudy = "2010-11",
                            NameOfGroup = "RD Kolkata",
                            Area = "Industrial Engineering",
                            Scope = ""
                        },
                        new TableRow
                        {
                            SrNo = 6,
                            ProjectTitle = "Energy Audit",
                            TypeOfStudy = "",
                            ClientName = "Kanti Bijlee Utpadan Ltd.",
                            ClientType = "State Government",
                            YearOfStudy = "2010-11",
                            NameOfGroup = "RD Kolkata",
                            Area = "Energy Management",
                            Scope = ""
                        },
                        new TableRow
                        {
                            SrNo = 7,
                            ProjectTitle = "Manpower Assessment Study",
                            TypeOfStudy = "",
                            ClientName = "Electro Steel Casting Pvt. Ltd.",
                            ClientType = "Private Sector",
                            YearOfStudy = "2010-11",
                            NameOfGroup = "RD Kolkata",
                            Area = "Industrial Engineering",
                            Scope = ""
                        },
                        new TableRow
                        {
                            SrNo = 8,
                            ProjectTitle = "Change over ISO 9001:2000 to ISO 9001:2008",
                            TypeOfStudy = "",
                            ClientName = "Govt. of Mizoram",
                            ClientType = "State Government",
                            YearOfStudy = "2010-11",
                            NameOfGroup = "RD Kolkata",
                            Area = "Industrial Engineering",
                            Scope = ""
                        },
                        new TableRow
                        {
                            SrNo = 9,
                            ProjectTitle = "Energy Audit",
                            TypeOfStudy = "",
                            ClientName = "DPSCL, West Bengal",
                            ClientType = "Private Sector",
                            YearOfStudy = "2010-11",
                            NameOfGroup = "RD Kolkata",
                            Area = "Energy Management",
                            Scope = ""
                        },
                        new TableRow
                        {
                            SrNo = 10,
                            ProjectTitle = "Productivity Study",
                            TypeOfStudy = "",
                            ClientName = "Marathan Electroic Motors, Kolkata",
                            ClientType = "Private Sector",
                            YearOfStudy = "2010-11",
                            NameOfGroup = "RD Kolkata",
                            Area = "Industrial Engineering",
                            Scope = ""
                        },
                        new TableRow        
                        {
                            SrNo = 11,
                            ProjectTitle = "Water Balance Study at Colonies",
                            TypeOfStudy = "",
                            ClientName = "Reserve Bank of India, Kolkata",
                            ClientType = "Central Government",
                            YearOfStudy = "2010-11",
                            NameOfGroup = "RD Kolkata",
                            Area = "Energy Management",
                            Scope = ""
                        },
                        new TableRow
                        {
                            SrNo = 12,
                            ProjectTitle = "Occupational Heath & Safety",
                            TypeOfStudy = "",
                            ClientName = "DPSC Ltd., West Bengal",
                            ClientType = "Private Sector",
                            YearOfStudy = "2010-11",
                            NameOfGroup = "RD Kolkata",
                            Area = "Technology Management",
                            Scope = ""
                        }
                    }
                }
            };
            var result = _service.GetConsultancyProjects(request);

            return Ok(result);
        }
    }
}
