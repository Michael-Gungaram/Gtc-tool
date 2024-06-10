
namespace Gtc.Models
{
    public static class ListExtensions
    { 
        public static string? ListToString<T>(T element) 
        {
            return element?.ToString();
        }
    }
}