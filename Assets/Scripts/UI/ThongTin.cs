using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ThongTin : MonoBehaviour
{
    public static ThongTin instance;

    public int healthSkill;

    [SerializeField] TextMeshProUGUI textheal;
    [SerializeField] TextMeshProUGUI textmana;
    [SerializeField] TextMeshProUGUI textdame;

    [SerializeField] Image itemfram;
    [SerializeField] List<Sprite> itemsprites;
    [SerializeField] List<TextMeshProUGUI> itemprites;

    void Awake()
    { 
        this.gameObject.SetActive(false);
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Update()
    {
        UpDateInfo();
        ChangeItem();
    }

    public void UpDateInfo()
    {
        textheal.text = "Health: " + FindAnyObjectByType<HealthPlayer>().health.ToString();
        textmana.text = "Mana: "+FindAnyObjectByType<HealthPlayer>().Mana.ToString();
        textdame.text = "Damage: "+FindAnyObjectByType<HealthPlayer>().playerDamage.ToString();
    }


    void ChangeItem()
    {
       
        if (itemfram != null && itemsprites != null && itemsprites.Count > 0)
        {
           
            itemfram.sprite = itemsprites[0];
            itemprites[0].text = healthSkill.ToString();
        }
       
    }

}
