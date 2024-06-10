// See https://aka.ms/new-console-template for more information
using Gtc.Models;
using Gtc.Models.FederalRegister;
using GtcTool.Models.FederalRegister;


var response = new Response(48, "Documents with an effective date in 2023 and from Agriculture Department", 24, "https://...");
var document = new Document("Child and adult care food...", "Notice", "This notice is...", "2023-14317", "https://...", "https://...", "https://...", "2023-01-01", "...");
var agency = new Agency("DEPARTMENT OF AGRICULTURE", "Agriculture Department", 12, "https://...", "https://...", 12, "agriculture-department");
string? resultRes = ListExtensions.ListToString(response);
string? resultDoc = ListExtensions.ListToString(document);
string? resultAgency = ListExtensions.ListToString(agency);

Console.WriteLine(resultRes);
Console.WriteLine(resultDoc);
Console.WriteLine(resultAgency);

