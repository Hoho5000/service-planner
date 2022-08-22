using BlazorTemplater;
using Microsoft.Extensions.Localization;
using ServicePlanner.Service.Components;
using ServicePlanner.Service;
using WkHtmlToPdfDotNet;
using WkHtmlToPdfDotNet.Contracts;
using ServicePlanner.Resources.Language;

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

        public byte[] GenerateServicePdf(Service.Models.Service service)
        {
            string component = RenderComponent(service);

            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = {
                    ColorMode = ColorMode.Color,
                    Orientation = Orientation.Portrait,
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

        private string RenderComponent(Service.Models.Service service)
        {
            var renderer = new ComponentRenderer<OrderOfServiceDisplay>();
            renderer.Set(c => c.ServiceItems, service.Items);
            renderer.AddService(localizer);
            renderer.UseLayout<OrderOfServiceLayout>();
            return renderer.Render();
        }
    }
}
