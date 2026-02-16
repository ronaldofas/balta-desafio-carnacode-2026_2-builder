using System;
using System.Collections.Generic;

public class ExcelReportBuilder : IReportBuilder
{
    private SalesReport _report = new SalesReport();

    public ExcelReportBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        _report = new SalesReport();
        // Define configuração padrão para este tipo de builder
        _report.Format = "Excel";
    }

    public SalesReport Build()
    {
        SalesReport result = _report;
        Reset();
        return result;
    }

    public IReportBuilder SetTitle(string title)
    {
        _report.Title = title;
        return this;
    }

    public IReportBuilder SetFormat(string format)
    {
        _report.Format = format;
        return this;
    }

    public IReportBuilder SetStartDate(DateTime startDate)
    {
        _report.StartDate = startDate;
        return this;
    }

    public IReportBuilder SetEndDate(DateTime endDate)
    {
        _report.EndDate = endDate;
        return this;
    }

    public IReportBuilder SetIncludeHeader(bool includeHeader)
    {
        _report.IncludeHeader = includeHeader;
        return this;
    }

    public IReportBuilder SetIncludeFooter(bool includeFooter)
    {
        _report.IncludeFooter = includeFooter;
        return this;
    }

    public IReportBuilder SetHeaderText(string headerText)
    {
        _report.HeaderText = headerText;
        return this;
    }

    public IReportBuilder SetFooterText(string footerText)
    {
        _report.FooterText = footerText;
        return this;
    }

    public IReportBuilder SetIncludeCharts(bool includeCharts)
    {
        _report.IncludeCharts = includeCharts;
        return this;
    }

    public IReportBuilder SetChartType(string chartType)
    {
        _report.ChartType = chartType;
        return this;
    }

    public IReportBuilder SetIncludeSummary(bool includeSummary)
    {
        _report.IncludeSummary = includeSummary;
        return this;
    }

    public IReportBuilder SetColumns(List<string> columns)
    {
        _report.Columns = columns;
        return this;
    }

    public IReportBuilder SetFilters(List<string> filters)
    {
        _report.Filters = filters;
        return this;
    }

    public IReportBuilder SetSortBy(string sortBy)
    {
        _report.SortBy = sortBy;
        return this;
    }

    public IReportBuilder SetGroupBy(string groupBy)
    {
        _report.GroupBy = groupBy;
        return this;
    }

    public IReportBuilder SetIncludeTotals(bool includeTotals)
    {
        _report.IncludeTotals = includeTotals;
        return this;
    }

    public IReportBuilder SetOrientation(string orientation)
    {
        _report.Orientation = orientation;
        return this;
    }

    public IReportBuilder SetPageSize(string pageSize)
    {
        _report.PageSize = pageSize;
        return this;
    }

    public IReportBuilder SetIncludePageNumbers(bool includePageNumbers)
    {
        _report.IncludePageNumbers = includePageNumbers;
        return this;
    }

    public IReportBuilder SetCompanyLogo(string companyLogo)
    {
        _report.CompanyLogo = companyLogo;
        return this;
    }

    public IReportBuilder SetWaterMark(string waterMark)
    {
        _report.WaterMark = waterMark;
        return this;
    }
}