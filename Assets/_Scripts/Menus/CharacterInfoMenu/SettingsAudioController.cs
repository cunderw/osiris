using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsAudioController : MonoBehaviour {

    [SerializeField]
    private GameObject musicSlider, sfxSlider, voiceSlider;
    public AudioMixer mixer;
    void start() {
        // TODO - Set from saved value
        musicSlider.GetComponent<Slider>().value = mixer.GetFloat("MusicVolume")
    }
    public void MusicSlider(float volume) {
        //float volume = musicSlider.GetComponent<Slider>().value;
        Debug.Log("[SettingsAudioController] -  Setting Music Volume To: " + volume);
        mixer.SetFloat("MusicVolume", Mathf.Log10(volume) * 20);
    }

    public void SoundEffectsSlider(float volume) {
        Debug.Log("[SettingsAudioController] -  Setting Music Volume To: " + volume);
        mixer.SetFloat("SFXVolume", Mathf.Log10(volume) * 20);
    }

    public void VoiceSlider(float volume) {
        Debug.Log("[SettingsAudioController] -  Setting Music Volume To: " + volume);
        mixer.SetFloat("VoiceVolume", Mathf.Log10(volume) * 20);
    }
}