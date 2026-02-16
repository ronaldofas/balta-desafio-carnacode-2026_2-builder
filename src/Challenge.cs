// DESAFIO: Gerador de Relatórios Complexos
// PROBLEMA: Sistema precisa gerar diferentes tipos de relatórios (PDF, Excel, HTML)
// com múltiplas configurações opcionais (cabeçalho, rodapé, gráficos, tabelas, filtros)
// O código atual usa construtores enormes ou muitos setters, tornando difícil criar relatórios

using System;
using System.Collections.Generic;

namespace DesignPatternChallenge
{
    // Contexto: Sistema de BI que gera relatórios customizados para diferentes departamentos
    // Cada relatório pode ter dezenas de configurações opcionais
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Relatórios ===");

            // Problema 1: Construtor com muitos parâmetros - difícil de ler e usar
            // Solução: Utilização do padrão Fluent Builder para eliminar o construtor telescópico e 
            // melhorar a legibilidade.
            var report1 = new PdfReportBuilder()
                .SetTitle("Vendas Mensais")
                .SetStartDate(new DateTime(2024, 1, 1))
                .SetEndDate(new DateTime(2024, 1, 31))
                .SetIncludeHeader(true)
                .SetIncludeFooter(true)
                .SetHeaderText("Relatório de Vendas")
                .SetFooterText("Confidencial")
                .SetIncludeCharts(true)
                .SetChartType("Bar")
                .SetIncludeSummary(true)
                .SetColumns(new List<string> { "Produto", "Quantidade", "Valor" })
                .SetFilters(new List<string> { "Status=Ativo" })
                .SetSortBy("Valor")
                .SetGroupBy("Categoria")
                .SetIncludeTotals(true)
                .SetOrientation("Portrait")
                .SetPageSize("A4")
                .SetIncludePageNumbers(true)
                .SetCompanyLogo("logo.png")
                .SetWaterMark("Confidencial")
                .Build();

            report1.Generate();

            // Problema 2: Muitos setters - ordem não importa, pode esquecer configurações obrigatórias
            // Solução: Implementação do ExcelReportBuilder que encapsula a lógica de criação e validação 
            // implícita através da interface fluente.
            var report2 = new ExcelReportBuilder()
                .SetTitle("Relatório Trimestral")
                .SetStartDate(new DateTime(2024, 1, 1))
                .SetEndDate(new DateTime(2024, 3, 31))
                .SetColumns(new List<string> { "Vendedor", "Região", "Total" })
                .SetIncludeCharts(true)
                .SetChartType("Line")
                .SetIncludeHeader(true)
                .SetGroupBy("Região")
                .SetIncludeTotals(true)
                .Build();

            report2.Generate();

            // Problema 3: Relatórios com configurações parecidas exigem repetir muito código
            // Solução: Utilização do ReportDirector para orquestrar a construção de relatórios padrões, 
            // evitando duplicação de código.
            var director = new ReportDirector();
            var builder3 = new PdfReportBuilder();
            director.MakeAnnualReport(builder3);
            var report3 = builder3.Build();

            report3.Generate();

            // Perguntas para reflexão:

            // - Como criar relatórios complexos sem construtores gigantes?
            // R: Usando o padrão Builder, onde cada configuração é definida por um método
            //    separado (ex: SetTitle(), SetChartType()), tornando a construção incremental
            //    e legível, em vez de um construtor com dezenas de parâmetros.

            // - Como garantir que configurações obrigatórias sejam definidas?
            // R: O Builder pode validar no método Build() se os campos obrigatórios foram
            //    preenchidos, lançando uma exceção caso contrário. A interface fluente também
            //    guia o desenvolvedor sobre quais opções estão disponíveis.

            // - Como reutilizar configurações comuns entre relatórios?
            // R: Usando o Director (ReportDirector), que encapsula sequências de configuração
            //    pré-definidas (ex: MakeAnnualReport()), evitando duplicação de código entre
            //    relatórios similares.

            // - Como tornar o processo de criação mais legível e fluente?
            // R: Retornando "this" (ou IReportBuilder) em cada método setter, permitindo o
            //    encadeamento de chamadas (Fluent Interface), como por exemplo:
            //    new PdfReportBuilder().SetTitle("Vendas").SetIncludeCharts(true).Build();
        }
    }
}
