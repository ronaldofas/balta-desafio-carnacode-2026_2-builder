using System;
using System.Collections.Generic;

public interface IReportBuilder
{
    SalesReport Build();
    IReportBuilder SetTitle(string title);
    IReportBuilder SetFormat(string format);
    IReportBuilder SetStartDate(DateTime startDate);
    IReportBuilder SetEndDate(DateTime endDate);
    IReportBuilder SetIncludeHeader(bool includeHeader);
    IReportBuilder SetIncludeFooter(bool includeFooter);
    IReportBuilder SetHeaderText(string headerText);
    IReportBuilder SetFooterText(string footerText);
    IReportBuilder SetIncludeCharts(bool includeCharts);
    IReportBuilder SetChartType(string chartType);
    IReportBuilder SetIncludeSummary(bool includeSummary);
    IReportBuilder SetColumns(List<string> columns);
    IReportBuilder SetFilters(List<string> filters);
    IReportBuilder SetSortBy(string sortBy);
    IReportBuilder SetGroupBy(string groupBy);
    IReportBuilder SetIncludeTotals(bool includeTotals);
    IReportBuilder SetOrientation(string orientation);
    IReportBuilder SetPageSize(string pageSize);
    IReportBuilder SetIncludePageNumbers(bool includePageNumbers);
    IReportBuilder SetCompanyLogo(string companyLogo);
    IReportBuilder SetWaterMark(string waterMark);
}