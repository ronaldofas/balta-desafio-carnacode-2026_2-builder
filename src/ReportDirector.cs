using System;
using System.Collections.Generic;

public class ReportDirector
{
    public void MakeAnnualReport(IReportBuilder builder)
    {
        builder.SetTitle("Vendas Anuais")
               .SetStartDate(new DateTime(2024, 1, 1))
               .SetEndDate(new DateTime(2024, 12, 31))
               .SetIncludeHeader(true)
               .SetHeaderText("Relatório de Vendas")
               .SetIncludeFooter(true)
               .SetFooterText("Confidencial")
               .SetColumns(new List<string> { "Produto", "Quantidade", "Valor" })
               .SetIncludeCharts(true)
               .SetChartType("Pie")
               .SetIncludeTotals(true)
               .SetOrientation("Landscape")
               .SetPageSize("A4");
    }
}