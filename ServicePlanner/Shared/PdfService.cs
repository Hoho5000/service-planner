using BlazorTemplater;
using Microsoft.Extensions.Localization;
using ServicePlanner.Resources.Language;
using ServicePlanner.Bulletin;
using iText.Html2pdf;
using iText.Kernel.Pdf;
using iText.Kernel.Geom;

namespace ServicePlanner.Shared
{
    public class PdfService
    {
        private IStringLocalizer<Strings> localizer;

        public PdfService(IStringLocalizer<Strings> localize)
        {
            localizer = localize;
        }

        public byte[] GenerateBulletinPdf(BulletinData data)
        {
            string insidePage = RenderInsidePage(data);

            var pdfStream = new MemoryStream();

            var document = new PdfDocument(new PdfWriter(pdfStream));
            document.SetDefaultPageSize(PageSize.LETTER.Rotate());

            HtmlConverter.ConvertToPdf(insidePage, document, new ConverterProperties());

            return pdfStream.ToArray();
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
