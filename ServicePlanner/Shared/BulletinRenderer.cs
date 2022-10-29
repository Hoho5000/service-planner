using BlazorTemplater;
using Microsoft.Extensions.Localization;
using ServicePlanner.Resources.Language;
using ServicePlanner.Bulletin;
using System.Text;

namespace ServicePlanner.Shared
{
    public class BulletinRenderer
    {
        private IStringLocalizer<Strings> localizer;

        public BulletinRenderer(IStringLocalizer<Strings> localize)
        {
            localizer = localize;
        }

        public byte[] GenerateBulletinFile(BulletinData data)
        {
            string insidePage = RenderInsidePage(data);

            return Encoding.ASCII.GetBytes(insidePage);
        }

        private string RenderInsidePage(BulletinData data)
        {
            var renderer = new ComponentRenderer<ServiceDisplay>();
            renderer.Set(c => c.Service, data.Service);
            renderer.AddService(localizer);
            renderer.UseLayout<BulletinLayout>();
            return renderer.Render();
        }
    }
}
