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


    [SerializeField] Image itemfram;
    [SerializeField] List<Sprite> itemsprites ;
    private void Update()
    {
        UpDownHeal();
        ChangeItem();
    }

    public void UpDownHeal()
    {
        healslider.value = 99;
        textheal.text = healslider.value.ToString()+" HP";
    }
    public void UpDownMana()
    {
        textmana.text = manaslider.value.ToString()+" Mana";
        manaslider.value = 49;
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

