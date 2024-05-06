using System.Text.Json;

namespace Nameless.Utils
{
    public class FileManager
    {
        public static string fileName = "settings.json";

        public static string filePath
        {
            get
            {
                return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            }
        }

        public static T? Load<T>() where T : class
        {
            try
            {
                string jsonString = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<T>(jsonString);
            }
            catch
            {
                MessageBox.Show($"File could not be read!\n{filePath}");
            }

            return null;
        }

        public static void Save<T>(T data)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(data, new JsonSerializerOptions() { WriteIndented = true });
                File.WriteAllText(filePath, jsonString);
            }
            catch
            {
                MessageBox.Show($"File could not be saved!\n{filePath}");
            }
        }
    }
}
