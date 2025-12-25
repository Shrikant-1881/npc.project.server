using Microsoft.AspNetCore.Mvc;
using System;
using static npc.project.server.Models.Service;

namespace npc.project.server.Services
{
    public class ServiceService
    {
        public PagedResponse<TableRow> GetConsultancyProjects([FromQuery] TableReq request)
        {
            var query = _projects.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request.Search))
            {
                var search = request.Search.ToLower();
                query = query.Where(x =>
                    x.ProjectTitle.ToLower().Contains(search) ||
                    x.ClientName.ToLower().Contains(search) ||
                    x.Area.ToLower().Contains(search)
                );
            }

            var totalCount = query.Count();

            var data = query
                .Skip((request.Page - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToList();

            return new PagedResponse<TableRow>
            {
                Data = data,
                TotalCount = totalCount
            };
        }


        private static List<TableRow> _projects = new()
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
            },
            new TableRow
            {
                SrNo = 13,
                ProjectTitle = "Details Energy Audit",
                TypeOfStudy = "",
                ClientName = "Andrew Yule , Kalyani",
                ClientType = "Private Sector",
                YearOfStudy = "2010-11",
                NameOfGroup = "RD Kolkata",
                Area = "Energy Management",
                Scope = ""
            },
            new TableRow
            {
                SrNo = 14,
                ProjectTitle = "Implementation of ISO 9001:2008",
                TypeOfStudy = "",
                ClientName = "West Bengal Minorities Development & Finance",
                ClientType = "State Government",
                YearOfStudy = "2010-11",
                NameOfGroup = "RD Kolkata",
                Area = "Industrial Engineering",
                Scope = ""
            },
            new TableRow
            {
                SrNo = 15,
                ProjectTitle = "Implementation of ISO 9001:2008",
                TypeOfStudy = "",
                ClientName = "DM Office, Hoogly, West Bengal",
                ClientType = "State Government",
                YearOfStudy = "2010-11",
                NameOfGroup = "RD Kolkata",
                Area = "Industrial Engineering",
                Scope = ""
            },
            new TableRow
            {
                SrNo = 16,
                ProjectTitle = "Energy Audit",
                TypeOfStudy = "",
                ClientName = "Electro Steel Casting Pvt. Ltd.",
                ClientType = "Private Sector",
                YearOfStudy = "2010-11",
                NameOfGroup = "RD Kolkata",
                Area = "Energy Management",
                Scope = ""
            },
            new TableRow
            {
                SrNo = 17,
                ProjectTitle = "Safety Audit",
                TypeOfStudy = "",
                ClientName = "Bokaro Power Supply Cop. Ltd.",
                ClientType = "Private Sector",
                YearOfStudy = "2010-11",
                NameOfGroup = "RD Kolkata",
                Area = "Technology Management",
                Scope = ""
            },
            new TableRow
            {
                SrNo = 18,
                ProjectTitle = "QMS ISO 9001:2008",
                TypeOfStudy = "",
                ClientName = "Bokaro Power Supply Cop. Ltd.",
                ClientType = "Private Sector",
                YearOfStudy = "2010-11",
                NameOfGroup = "RD Kolkata",
                Area = "Industrial Engineering",
                Scope = ""
            },
            new TableRow
            {
                SrNo = 19,
                ProjectTitle = "Energy optimization of Conveyor Belt",
                TypeOfStudy = "",
                ClientName = "Poniex Yule",
                ClientType = "Private Sector",
                YearOfStudy = "2011-12",
                NameOfGroup = "RD Kolkata",
                Area = "Energy Management",
                Scope = ""
            },
            new TableRow
            {
                SrNo = 20,
                ProjectTitle = "Energy Audit",
                TypeOfStudy = "",
                ClientName = "DVC-DTPS, Durgapur",
                ClientType = "Central Government",
                YearOfStudy = "2011-12",
                NameOfGroup = "RD Kolkata",
                Area = "Energy Management",
                Scope = ""
            },
            new TableRow
            {
                SrNo = 21,
                ProjectTitle = "Energy Audit",
                TypeOfStudy = "",
                ClientName = "Electro Steel Casting Pvt. Ltd.",
                ClientType = "Private Sector",
                YearOfStudy = "2010-11",
                NameOfGroup = "RD Kolkata",
                Area = "Energy Management",
                Scope = ""
            },
            new TableRow
            {
                SrNo = 22,
                ProjectTitle = "Safety Audit",
                TypeOfStudy = "",
                ClientName = "Bokaro Power Supply Cop. Ltd.",
                ClientType = "Private Sector",
                YearOfStudy = "2010-11",
                NameOfGroup = "RD Kolkata",
                Area = "Technology Management",
                Scope = ""
            },
            new TableRow
            {
                SrNo = 23,
                ProjectTitle = "QMS ISO 9001:2008",
                TypeOfStudy = "",
                ClientName = "Bokaro Power Supply Cop. Ltd.",
                ClientType = "Private Sector",
                YearOfStudy = "2010-11",
                NameOfGroup = "RD Kolkata",
                Area = "Industrial Engineering",
                Scope = ""
            },
            new TableRow
            {
                SrNo = 24,
                ProjectTitle = "Energy optimization of Conveyor Belt",
                TypeOfStudy = "",
                ClientName = "Poniex Yule",
                ClientType = "Private Sector",
                YearOfStudy = "2011-12",
                NameOfGroup = "RD Kolkata",
                Area = "Energy Management",
                Scope = ""
            },
            new TableRow
            {
                SrNo = 25,
                ProjectTitle = "Energy Audit",
                TypeOfStudy = "",
                ClientName = "DVC-DTPS, Durgapur",
                ClientType = "Central Government",
                YearOfStudy = "2011-12",
                NameOfGroup = "RD Kolkata",
                Area = "Energy Management",
                Scope = ""
            },

        };
    }
}
