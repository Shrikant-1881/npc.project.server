using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using static npc.project.server.Models.PageEditor;

namespace npc.project.server.Services
{ 
    public class PageEditorService //: IPageContentService
    {
        //private readonly AppDbContext _context;

        public PageEditorService()
        {
        }
        
        private static readonly Dictionary<string, string> _data =
        new Dictionary<string, string>
        {
            {
                "about-us",
                @"{
                  ""time"": 1735360000000,
                  ""blocks"": [
                    {
                      ""type"": ""header"",
                      ""data"": { ""text"": ""Citizen's Charter"", ""level"": 1 }
                    },
                    {
                      ""type"": ""paragraph"",
                      ""data"": {
                        ""text"": ""National Productivity Council of India (NPC), established in the year 1958, is an autonomous organization under Department for Promotion of Industry & Internal Trade, Ministry of Commerce and Industry, Government of India.""
                      }
                    },
                    {
                      ""type"": ""header"",
                      ""data"": { ""text"": ""Vision"", ""level"": 2 }
                    },
                    {
                      ""type"": ""paragraph"",
                      ""data"": {
                        ""text"": ""NPC to be the knowledge leader in productivity...""
                      }
                    },
                    {
                      ""type"": ""list"",
                      ""data"": {
                        ""style"": ""unordered"",
                        ""items"": [
                          ""To promote innovation-led productivity"",
                          ""To propagate productivity consciousness"",
                          ""To demonstrate value addition"",
                          ""To act as a total solution provider"",
                          ""To enhance international outreach""
                        ]
                      }
                    }
                  ],
                  ""version"": ""2.29.1""
                }"
            }
        };

        public string GetContent(string pageKey)
        {
            return _data.ContainsKey(pageKey) ? _data[pageKey] : null;
        }

        public void SaveContent(string pageKey, string contentJson)
        {
            _data[pageKey] = contentJson; // optional for now
        }
    }
}
