using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using npc.project.server.Models;
using npc.project.server.Services;
using static npc.project.server.Models.AboutUs;
namespace npc.project.server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : Controller
    {
       public AboutUsController() { }
        
        [HttpGet("getHeadquarters")]
        public IActionResult getHeadquarters()
        {
            var tables = new List<Table>
                {
                    new Table
                    {
                        Title = "DIRECTOR GENERAL",
                        Members = new List<Member>
                        {
                            new Member
                            {
                                Name = "Smt. Neerja Sekhar, IAS",
                                Designation = "Director General",
                                Telephone = "011-24618480",
                                Mail = "dg.npc@npcindia.gov.in"
                            }
                        }
                    },

                    new Table
                    {
                        Title = "DIRECTOR GENERAL SECRETARIAT",
                        Members = new List<Member>
                        {
                            new Member
                            {
                                Name = "Shri Sanjeev Bhatia",
                                Designation = "PPS to DG",
                                Telephone = "011-24618480",
                                Mail = ""
                            }
                        }
                    },

                    new Table
                    {
                        Title = "DEPUTY DIRECTOR GENERAL",
                        Members = new List<Member>
                        {
                            new Member
                            {
                                Name = "Shri Umashankar Prasad",
                                Designation = "Deputy Director General",
                                Telephone = "011-24607337",
                                Mail = "us.prasad@npcindia.gov.in"
                            },
                            new Member
                            {
                                Name = "Shri Shirish Paliwal",
                                Designation = "Deputy Director General",
                                Telephone = "011-24607336",
                                Mail = "shirish.p@npcindia.gov.in"
                            }
                        }
                    },

                    new Table
                    {
                        Title = "ADMINISTRATION",
                        Members = new List<Member>
                        {
                            new Member
                            {
                                Name = "Sh. Vijay Kumar",
                                Designation = "Director Gr-II & Group Head (Admin)",
                                Telephone = "011-24607369",
                                Mail = "vijay.kumar@npcindia.gov.in"
                            },
                            new Member
                            {
                                Name = "Shri Yadu Kumar Yadav",
                                Designation = "Deputy Director (Admin)",
                                Telephone = "011-24607371",
                                Mail = "yk.yadav@npcindia.gov.in"
                            }
                        }
                    },

                    new Table
                    {
                        Title = "AGRI-BUSINESS GROUP",
                        Members = new List<Member>
                        {
                            new Member
                            {
                                Name = "Shri S.P. Singh",
                                Designation = "Director Gr-I & Group Head (AB)",
                                Telephone = "011-24607350",
                                Mail = "sp.singh@npcindia.gov.in"
                            },
                            new Member
                            {
                                Name = "Shri Sunil Kumar Singh",
                                Designation = "Director Gr-II (AB)",
                                Telephone = "011-24607326",
                                Mail = "sunilkr.singh@npcindia.gov.in"
                            }
                        }
                    },

                    new Table
                    {
                        Title = "ECONOMIC SERVICES & PRODUCTIVITY PROMOTION GROUP",
                        Members = new List<Member>
                        {
                            new Member
                            {
                                Name = "Shri Rajesh Sund",
                                Designation = "Director Gr-I & Group Head (ES & PP)",
                                Telephone = "011-24607303",
                                Mail = "rajesh.sund@npcindia.gov.in"
                            }
                        }
                    },

                    new Table
                    {
                        Title = "ENERGY MANAGEMENT GROUP",
                        Members = new List<Member>
                        {
                            new Member
                            {
                                Name = "Sh. Anand Verma",
                                Designation = "Director Gr-II & Group Head (EM)",
                                Telephone = "011-24607351",
                                Mail = "anand.verma@npcindia.gov.in"
                            }
                        }
                    },

                    new Table
                    {
                        Title = "ENVIRONMENT AND CLIMATE ACTION GROUP",
                        Members = new List<Member>
                        {
                            new Member
                            {
                                Name = "Shri K.D. Bhardwaj",
                                Designation = "Director Gr-I & Group Head (ECA)",
                                Telephone = "011-24607313",
                                Mail = "kd.bhardwaj@npcindia.gov.in"
                            },
                            new Member
                            {
                                Name = "Dr. Shukla Pal Maitra",
                                Designation = "Director Gr-I (ECA)",
                                Telephone = "011-24607310",
                                Mail = "shukla.pal@npcindia.gov.in"
                            }
                        }
                    },

                    new Table
                    {
                        Title = "FINANCE",
                        Members = new List<Member>
                        {
                            new Member
                            {
                                Name = "Shri Shirish Paliwal",
                                Designation = "Deputy Director General & Group Head (Finance)",
                                Telephone = "011-24607336",
                                Mail = "shirish.p@npcindia.gov.in"
                            },
                            new Member
                            {
                                Name = "Mrs. Sweta Kumari",
                                Designation = "Director Gr-II (Finance)",
                                Telephone = "011-24607361",
                                Mail = "sweta.kumari@npcindia.gov.in"
                            }
                        }
                    },

                    new Table
                    {
                        Title = "HUMAN RESOURCE MANAGEMENT GROUP",
                        Members = new List<Member>
                        {
                            new Member
                            {
                                Name = "Shri Umashankar Prasad",
                                Designation = "Deputy Director General & Group Head (HRM)",
                                Telephone = "011-24607337",
                                Mail = "us.prasad@npcindia.gov.in"
                            },
                            new Member
                            {
                                Name = "Shri D.K Rahul",
                                Designation = "Director Gr-II (HRM)",
                                Telephone = "011-24607352",
                                Mail = "dk.rahul@npcindia.gov.in"
                            }
                        }
                    },

                    new Table
                    {
                        Title = "INFORMATION TECHNOLOGY GROUP",
                        Members = new List<Member>
                        {
                            new Member
                            {
                                Name = "Shri Nikhil Panchbhai",
                                Designation = "Director Gr-I & Group Head (IT)",
                                Telephone = "011-24607321",
                                Mail = "nikhil.p@npcindia.gov.in"
                            },
                            new Member
                            {
                                Name = "Shri Rajeev Gupta",
                                Designation = "Deputy Director (IT)",
                                Telephone = "011-24607335",
                                Mail = "rajeev.gupta@npcindia.gov.in"
                            }
                        }
                    },

                    new Table
                    {
                        Title = "INTERNATIONAL SERVICES GROUP",
                        Members = new List<Member>
                        {
                            new Member
                            {
                                Name = "Shri K.D. Bhardwaj",
                                Designation = "Director Gr-I & Group Head (IS)",
                                Telephone = "011-24607313",
                                Mail = "kd.bhardwaj@npcindia.gov.in"
                            },
                            new Member
                            {
                                Name = "Shri Anupam Saini",
                                Designation = "Assistant Director (IS)",
                                Telephone = "011-24607312",
                                Mail = "mayank.verma@npcindia.gov.in"
                            }
                        }
                    },

                    new Table
                    {
                        Title = "PLANNING MONITORING AND COORDINATION CELL",
                        Members = new List<Member>
                        {
                            new Member
                            {
                                Name = "Shri Shirish Paliwal",
                                Designation = "Deputy Director General & Incharge (PMC)",
                                Telephone = "011-24607336",
                                Mail = "shirish.p@npcindia.gov.in"
                            }
                        }
                    }
                };


            return Ok(tables);
            }

        [HttpGet("getOffices")]
        public IActionResult getOffices()
        {
            var tables = new List<Table>
            {
                new Table {
                    Title = "BENGALURU",
                    Members = new List<Member> {
                        new Member {
                            Name = "Shri Swarupan Das",
                            Designation = "RegionalDirector",
                            Telephone = "080-23467294, 9019883123",
                            Mail = "swarupan.das@npcindia.gov.in; bangalore@npcindia.gov.in",
                            Address = "National Productivity Council 2nd Floor, Abhaya Complex KSDB Building, 55, Risaldar Street Seshadripuram Bangalore 560 020"
                        }
                    }
                },
                new Table {
                    Title = "BHUBANESWAR",
                    Members = new List<Member> {
                        new Member {
                            Name = "Shri Avijit Nayak",
                            Designation = "Director Gr-II & Regional Director (Bhubaneswar)",
                            Telephone = "0674-2397381/26",
                            Mail = "avijit.nayak@npcindia.gov.in",
                            Address = "National Productivity Council A/7, Surya Nagar, Bhubaneswar-751003, Odisha"
                        },
                        new Member {
                            Name = "Shri Shyama Prasad",
                            Designation = "Deputy Director (Bhubaneswar )",
                            Telephone = "0674 2397326",
                            Mail = "shyama.prasad1@npcindia.gov.in",
                            Address = "National Productivity Council A/7, Surya Nagar, Bhubaneswar-751003, Odisha"
                        }
                    }
                },
                new Table {
                    Title = "CHANDIGARH",
                    Members = new List<Member> {
                        new Member {
                            Name = "Ashok Kumar",
                            Designation = "In charge -Regional Director",
                            Telephone = "9888481938",
                            Mail = "ashok.kumar@npcindia.gov.in",
                            Address = "National Productivity Council, Chandigarh CRRID Campus, Centre for Research in Rural and Industrial Development, Plot 2-A, Madhya Marg, Sector 19A, Chandigarh, 160019"
                        },
                        new Member {
                            Name = "Shri Suvyendu Shivakar",
                            Designation = "Deputy Director",
                            Telephone = "6287872655",
                            Mail = "suvyendu.s@npcindia.gov.in",
                            Address = "National Productivity Council, Chandigarh CRRID Campus, Centre for Research in Rural and Industrial Development, Plot 2-A, Madhya Marg, Sector 19A, Chandigarh, 160019"
                        }
                    }
                }
            };

            return Ok(tables);
        }
    }
}
