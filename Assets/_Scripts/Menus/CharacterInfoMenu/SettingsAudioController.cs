using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsAudioController : MonoBehaviour {

    [SerializeField]
    private GameObject musicSlider, sfxSlider, voiceSlider;
    void start() {
        // TODO - Set from saved value
    }
    public void MusicSlider() {
        float volume = musicSlider.GetComponent<Slider>().value;
        Debug.Log("[SettingsAudioController] -  Setting Music Volume To: " + volume);
    }

    public void SoundEffectsSlider() {
        float volume = sfxSlider.GetComponent<Slider>().value;
        Debug.Log("[SettingsAudioController] -  Setting Music Volume To: " + volume);
    }

    public void VoiceSlider() {
        float volume = voiceSlider.GetComponent<Slider>().value;
        Debug.Log("[SettingsAudioController] -  Setting Music Volume To: " + volume);
    }
}