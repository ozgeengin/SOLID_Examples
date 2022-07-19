namespace SOLID.OCP.Violation
{
    internal class ReportCodeSmell
    {
        public bool GenerateReport(ReportType reportType)
        {
            switch (reportType)
            {
                case ReportType.HTML:
                    return GenerateHTMLReport();
                case ReportType.JSON:
                    return GenerateJSONReport();
                case ReportType.PDF:
                    return GeneratePDFReport();
                default: throw new Exception();
            }
        }

        private bool GenerateHTMLReport()
        {
            return true;
        }
        private bool GenerateJSONReport()
        {
            return true;
        }
        private bool GeneratePDFReport()
        {
            return true;
        }
    }
}
