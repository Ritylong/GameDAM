using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using System;
using UnityEngine.UI;
public class Achiment : MonoBehaviour
{
    StorageHelper storageHelper;
    GameDataPlayed played;
    public string nextSceneName;

    [SerializeField] GameObject highScore;
    [SerializeField] GameObject row;
    private void Start()
    {

        storageHelper = new StorageHelper();
        storageHelper.LoadData();
        played = storageHelper.played;
    }
    public void achivement()
    {
        storageHelper.LoadData();
        played = storageHelper.played;

        played.plays.Sort((x, y) => y.score.CompareTo(x.score));
        played.plays = played.plays.GetRange(0, Math.Min(5, played.plays.Count));

        for (int i = 0; i < played.plays.Count; i++)
        {
            var rowInstance = Instantiate(row, row.transform.parent);
            rowInstance.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = (i + 1).ToString();
            rowInstance.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = played.plays[i].score.ToString();
            rowInstance.transform.GetChild(2).GetComponent<TMPro.TextMeshProUGUI>().text = played.plays[i].timePlayed.ToString();
            rowInstance.SetActive(true);
        }
        highScore.SetActive(true);

       
    }
}
   

