using System.IO;

Console.WriteLine("Enter file full path: ");
string path = Console.ReadLine();

try
{  
    using (StreamReader sr = File.OpenText(path))
    {
        Dictionary<string, int> election = new Dictionary<string, int>();

        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(',');
            string key = line[0];
            int value = int.Parse(line[1]);

            if (election.ContainsKey(key))
            {
                election[key] += value; 
            }
            else
            {
                election[key] = value;
            }

        }

        foreach(var item in election)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }
}
catch(IOException e)
{
    Console.WriteLine(e.Message);
}