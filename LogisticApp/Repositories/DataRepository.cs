using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class DataRepository<T>
{
    private readonly string _filePath;

    public DataRepository(string fileName)
    {
        string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LogisticsCRM");
        Directory.CreateDirectory(folderPath);  
        _filePath = Path.Combine(folderPath, fileName);
    }

    public void Save(List<T> data)
    {
        File.WriteAllText(_filePath, JsonSerializer.Serialize(data));
    }

    public List<T> Load()
    {
        if (File.Exists(_filePath))
        {
            string json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }
        return new List<T>();
    }
}
