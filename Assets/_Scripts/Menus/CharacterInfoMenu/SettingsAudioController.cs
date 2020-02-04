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
    public void MusicSlider(float volume) {
        Debug.Log("[SettingsAudioController] -  Setting Music Volume To: " + volume);
    }

    public void SoundEffectsSlider(float volume) {
        Debug.Log("[SettingsAudioController] -  Setting Music Volume To: " + volume);
    }

    public void VoiceSlider(float volume) {
        Debug.Log("[SettingsAudioController] -  Setting Music Volume To: " + volume);
    }
}