using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsAudioController : MonoBehaviour {

    [SerializeField]
    private Slider musicSlider, soundEffectsSlider, voiceSlider;

    [SerializeField]
    private AudioMixer mixer;

    void Start() {
        musicSlider.value = PlayerPrefs.GetFloat("MusicVolume", 1f);
        soundEffectsSlider.value = PlayerPrefs.GetFloat("SoundEffectsVolume", 1f);
        voiceSlider.value = PlayerPrefs.GetFloat("VoiceVolume", 1f);
    }

    public void MusicSlider(float volume) {
        //float volume = musicSlider.GetComponent<Slider>().value;
        Debug.Log("[SettingsAudioController] -  Setting Music Volume To: " + volume);
        mixer.SetFloat("MusicVolume", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("MusicVolume", volume);
    }

    public void SoundEffectsSlider(float volume) {
        Debug.Log("[SettingsAudioController] -  Setting Music Volume To: " + volume);
        mixer.SetFloat("SoundEffectsVolume", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("SoundEffectsVolume", volume);
    }

    public void VoiceSlider(float volume) {
        Debug.Log("[SettingsAudioController] -  Setting Music Volume To: " + volume);
        mixer.SetFloat("VoiceVolume", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("VoiceVolume", volume);
    }
}