using System.IO;
using System.Globalization;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalFolderPath = @"/Users/gabrielleoliveira/Downloads/CSharp/Projects/Files/SoldItems";
            string originalFileName = "soldItems.csv";
            string originalFilePath = Path.Combine(originalFolderPath, originalFileName);
            string[] csvContent =
            {
                "TV LED,1290.99,1",
                "Video Game Chair,350.50,3",
                "Iphone X,900.00,2",
                "Samsung Galaxy 9,850.00,2"
            };

            string outFolderPath = Path.Combine(originalFolderPath, "Out");
            string summaryFileName = "Summary.csv";
            string summaryFilePath = Path.Combine(outFolderPath, summaryFileName); 

            try
            {
                File.WriteAllLines(originalFilePath, csvContent);

                if (!Directory.Exists(outFolderPath))
                {
                    Directory.CreateDirectory(outFolderPath);
                }
                string[] lines = File.ReadAllLines(originalFilePath);
                string[] summaryContent = new string[lines.Length];
                
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] data = lines[i].Split(',');
                    string product = data[0];
                    int qte = int.Parse(data[2]);
                    double price = double.Parse(data[1], CultureInfo.InvariantCulture);

                    double totalPrice = qte * price;

                    summaryContent[i] = $"{product},{totalPrice}"; 
                }

                File.WriteAllLines(summaryFilePath, summaryContent);
                Console.WriteLine("Arquivo summary criado com sucesso");

            }
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}