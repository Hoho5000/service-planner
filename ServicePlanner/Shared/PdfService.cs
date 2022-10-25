using BlazorTemplater;
using Microsoft.Extensions.Localization;
using WkHtmlToPdfDotNet;
using WkHtmlToPdfDotNet.Contracts;
using ServicePlanner.Resources.Language;
using ServicePlanner.Bulletin;

namespace ServicePlanner.Shared
{
    public class PdfService
    {
        private IStringLocalizer<Strings> localizer;

        private IConverter pdfConverter;

        public PdfService(IStringLocalizer<Strings> localize, IConverter converter)
        {
            localizer = localize;
            pdfConverter = converter;
        }

        public byte[] GenerateBulletinPdf(BulletinData data)
        {
            string component = RenderComponent(data);

            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = {
                    ColorMode = ColorMode.Color,
                    Orientation = Orientation.Landscape,
                    PaperSize = PaperKind.A4,
                    Margins = new MarginSettings() { Top = 10 },
                },
                Objects = {
                    new ObjectSettings()
                    {
                        HtmlContent = component,
                    },
                }
            };

            return pdfConverter.Convert(doc);
        }

        private string RenderComponent(BulletinData data)
        {
            var renderer = new ComponentRenderer<ServiceDisplay>();
            renderer.Set(c => c.Service, data.Service);
            renderer.AddService(localizer);
            renderer.UseLayout<BulletinLayout>();
            return renderer.Render();
        }
    }
}
