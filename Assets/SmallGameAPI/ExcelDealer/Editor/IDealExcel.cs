using System.Data;

public interface IDealExcel
{
    string floader { get; }
    string fileName { get; }
    string Run(DataTable reader);
}
