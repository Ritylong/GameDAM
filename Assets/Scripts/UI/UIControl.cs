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

    private void Start()
    {
        playerHeal = FindAnyObjectByType<HealthPlayer>();
    }
    private void Update()
    {
        UpDownHeal();
        ChangeItem();
        UpDownMana();
        Coin();
      
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
    public void Coin()
    {
        textCoin.text = playerHeal.Coin.ToString();
    }
  

    void ChangeItem()
    {
        // Kiểm tra nếu Image component và Sprite không null
        if (itemfram != null && itemsprites != null && itemsprites.Count > 0)
        {
            // Gán sprite đầu tiên từ danh sách vào Image component
            itemfram.sprite = itemsprites[0];
        }
        else
        {
            Debug.LogError("Image component hoặc danh sách Sprite chưa được gán trong Inspector hoặc danh sách rỗng.");
        }
    }
}

