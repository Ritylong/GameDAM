using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class StorageHelper { 
    private readonly string filename = "game_data.txt";
    public GameDataPlayed played;
    public void LoadData()
    {
        played = new GameDataPlayed()
        {
            plays = new List<DataGame>() { }
        };
        string dataAsJson = StorageManager.LoadFromFile(filename);
        if (dataAsJson != null)
        {
            played = JsonUtility.FromJson<GameDataPlayed>(dataAsJson);
        }
    }

    public void SaveGame()
    {
        string dataAsJson = JsonUtility.ToJson(played);

        StorageManager.SaveToFile(filename, dataAsJson);
    }
}
