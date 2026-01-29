// See https://aka.ms/new-console-template for more information
using TextFilterApp;

var filters = new List<ITextFilter>
            {
                new TextFilterVowel(),
                new TextFilterLength(),
                new TextFilterLetter()
            };
var app = new TextFilter(filters);

// Read from file and apply filters
app.ReadAndApplyFiltersFromFile(@"C:\SourceFiles\sample.txt");
Console.WriteLine("Filtering Done");

