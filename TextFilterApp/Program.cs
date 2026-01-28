// See https://aka.ms/new-console-template for more information
using TextFilterApp;

var app = new TextFilter();

// Read from file and apply filters
app.ReadAndApplyFiltersFromFile(@"C:\SourceFiles\sample.txt");
Console.WriteLine("Filtering Done");

