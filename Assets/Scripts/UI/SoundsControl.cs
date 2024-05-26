using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class SoundsControl : MonoBehaviour
{
    AudioSource music;
    bool onMusic = true;
    [SerializeField] Slider musicSlider;
    

    void Start()
    {
        music = GetComponent<AudioSource>();

        MusicAwake();
        

    }

    void MusicAwake()
    {
        if(onMusic)
        {
            music.playOnAwake = true;
        }

    }
    public void UpdateMusic()
    {          
        if (onMusic)
        {
            music.enabled = true;
            
        }
        else
        {     
            music.enabled = false;        

        }
    }     
   
       
        
           
        
    
    public void UpMusic()
    {
        music.volume += 1 * 0.1f;
        musicSlider.value += 1;
    }
    public void MusicOO()
    {

        onMusic = !onMusic;
        UpdateMusic();
        
        
    }
    public void DownMusic()
    {
        
        music.volume -= 1*0.1f;
        musicSlider.value -= 1;
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
