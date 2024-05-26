using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuMusic : MonoBehaviour
{
    void Start()
    {
        // Kiểm tra nếu MusicManager chưa tồn tại, tạo nó
        if (Music.instance == null)
        {
            GameObject musicManager = new GameObject("Music");
            musicManager.AddComponent<AudioSource>();
            musicManager.AddComponent<Music>();

            // Cấu hình AudioSource
            AudioSource audioSource = musicManager.GetComponent<AudioSource>();
            audioSource.clip = Resources.Load<AudioClip>("m_audioClip");
            audioSource.loop = true;
            audioSource.Play();
        }
    }
}
