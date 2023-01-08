
using CreateJson;
using Newtonsoft.Json;

public class Program
{
    public static void Main(string[] args)
    {
        Record record = new Record();

        string JSONresult = JsonConvert.SerializeObject(record);

        // Create a path locally - Named a folder "json" in my C Drive

        // String Path - add the name of the file to be created 
        string path = @"C:\json\records.json";

        // If the path location contains a file
        // with the same name - delete the first one 
        // and create a new one!

        if (File.Exists(path))
        {
            File.Delete(path);
            using (var stream = new StreamWriter(path, true))
            {
                stream.WriteLine(JSONresult.ToString());
                stream.Close();
            }
        }
        else if (!File.Exists(path))
        {
            using (var stream = new StreamWriter(path, true))
            {
                stream.WriteLine(JSONresult.ToString());
                stream.Close();
            }
        }

    }
}
