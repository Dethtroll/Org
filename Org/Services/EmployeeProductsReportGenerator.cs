using System;
using System.Collections.Generic;
using System.Linq;
using Foxby.Core;
using Foxby.Core.DocumentBuilder;
using Foxby.Core.MetaObjects;
using Org.Common.Services;
using Org.Domain;

namespace Org.Services
{
    public class EmployeeProductsReportGenerator : IEmployeeProductsReportGenerator
    {
        public byte[] Generate(Employee employee, IEnumerable<Product> products)
        {

            using (var docxDocument = new DocxDocument(SimpleTemplate.EmptyWordFile))
            {
                var builder = new DocxDocumentBuilder(docxDocument);
                
                Action<IDocumentTableRowsBuilder> rows = x => products.All(t =>
                {
                    x.Row(t.Category.Name, t.Number, "1");
                    return true;
                }); 

                builder
                    .Tag(SimpleTemplate.ContentTagName,
                        x => x
                            .Left.Paragraph(p => p.Text($"Сотрудник: {employee.LastName} {employee.FirstName} {employee.MiddleName}"))
                            .Left.Paragraph("Выданная техника:")
                            .Table(t => t.Column("Техника").Column("Серийный номер").Column("Количество, шт."),
                                rows
                            )

                            .Left.Paragraph("")
                            .Left.Paragraph("Правила пользования техникой и материальная ответственность:")
                            .Left.Paragraph("1. Сотрудников несёт полную материальноую ответсвенность за выданную технику.")
                            .Left.Paragraph("2. Обязуется вернуть выданную технику по требованию начальника отдела.")
                            .Left.Paragraph("")
                            .Left.Paragraph("С правилами ознакомлен.")
                            .Left.Paragraph("Подпись: ____________")
                            .Left.Paragraph("Число: ______________")
                            );

                return docxDocument.ToArray();
            }
        }
    }
}
