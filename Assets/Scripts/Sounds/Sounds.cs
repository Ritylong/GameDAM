using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioClip collectSound;
    public AudioClip arrowSound;
    public AudioClip skillSound; // AudioClip cho âm thanh khi di chuyển
    public AudioSource audioSource; // Thành phần AudioSource để phát âm thanh
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

   public void SoundECollect()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = collectSound;

            // Phát âm thanh
            audioSource.Play();
        }
        else
        {
            audioSource.Stop();
        }
    }
    public void SoundAtk()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = arrowSound;
            audioSource.Play();
        }
    }

}
