using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class StorageManager
{


    public static bool SaveToFile(string filename, string json)
    {
        try
        {
            var fileStream = new FileStream(filename, FileMode.Create);
            using (var writer = new StreamWriter(fileStream))
            {
                writer.Write(json);
            }
            return true;
        }
        catch (System.Exception e)
        {
            Debug.Log("loi" + e.Message);
            return false;
        }

    }
    public static string LoadFromFile(string filename)
    {
        try
        {
            if (File.Exists(filename))
            {
                var fileStream = new FileStream(filename, FileMode.Open);
                using (var reader = new StreamReader(fileStream))
                {
                    return reader.ReadToEnd();
                       
                } 
            } else
            {
                Debug.Log("not found File" + filename);
                return null;
            }

        } 
        catch (System.Exception e)
        {
            Debug.Log("loi" + e.Message);
            return null;
        }
      }
    
}


   