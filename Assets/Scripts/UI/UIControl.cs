using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    [SerializeField] Slider healslider;
    [SerializeField] Slider manaslider;
    [SerializeField] TextMeshProUGUI textheal;
    [SerializeField] TextMeshProUGUI textmana;
    [SerializeField] TextMeshProUGUI textCoin;

    
    HealthPlayer playerHeal;


    [SerializeField] Image itemfram;
    [SerializeField] List<Sprite> itemsprites ;

    public bool playerDead;

    private void Start()
    {
        playerHeal = FindAnyObjectByType<HealthPlayer>();
    }
    private void Update()
    {
        UpDownHeal();
        ChangeItem();
        UpDownMana();
        UpCoin();
        if (playerDead)
        {
            DeadMenu();
            healslider.value = playerHeal.health;
            textheal.text = 0 + " HP";
           
        } else
        {
            //DeadMenuOff();
        }
      
    }

    public void UpDownHeal()
    {
        healslider.value =playerHeal.health;
        textheal.text = healslider.value.ToString()+" HP";
    }
    public void UpDownMana()
    {
        manaslider.value = playerHeal.Mana;
        textmana.text = manaslider.value.ToString()+" Mana";
       
    }
    public void UpCoin()
    {
        textCoin.text = playerHeal.Coin.ToString();
    }
  

    void ChangeItem()
    {
        // Kiểm tra nếu Image component và Sprite không null
        if (itemfram != null && itemsprites != null && itemsprites.Count > 0)
        {
            // Gán sprite đầu tiên từ danh sách vào Image component
            itemfram.sprite = itemsprites[1];
        }
        else
        {
            Debug.LogError("Image component hoặc danh sách Sprite chưa được gán trong Inspector hoặc danh sách rỗng.");
        }
    }

    public void DeadMenu()
    {
        GameObject[] allObjects = Resources.FindObjectsOfTypeAll<GameObject>();

        foreach (GameObject obj in allObjects)
        {
            if (obj.name == "DeadMenu")
            {
                obj.SetActive(true);
                break;
            }
        }
    }
    
    
}

