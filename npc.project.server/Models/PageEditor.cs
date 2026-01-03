namespace npc.project.server.Models
{
    public class PageEditor
    {
        public interface IPageContentService
        {
            string GetContent(string pageKey);
            void SaveContent(string pageKey, string contentJson);
        }

    }
}
