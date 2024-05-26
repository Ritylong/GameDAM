using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public Slider volumeSlider;
    public Toggle muteToggle;
    private AudioSource audioSource;

    void Start()
    {
        InitAudioManager();
    }

    void InitAudioManager()
    {
        // Lấy AudioSource từ MusicManager
        audioSource = Music.instance.GetComponent<AudioSource>();

        if (audioSource != null)
        {
            // Thiết lập giá trị ban đầu cho Slider và Toggle
            volumeSlider.value = audioSource.volume;
            muteToggle.isOn = audioSource.mute;

            // Gán sự kiện cho Slider và Toggle
            volumeSlider.onValueChanged.AddListener(SetVolume);
            muteToggle.onValueChanged.AddListener(ToggleMute);
        }
    }

    // Phương thức để điều chỉnh âm lượng
    public void SetVolume(float volume)
    {
        if (audioSource != null)
        {
            audioSource.volume = volume;
        }
    }

    // Phương thức để bật/tắt nhạc nền
    public void ToggleMute(bool isMuted)
    {
        if (audioSource != null)
        {
            audioSource.mute = isMuted;
        }
    }
}
