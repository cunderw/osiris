using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class InitPlayerPrefs : MonoBehaviour {
    // Start is called before the first frame update
    [SerializeField]
    private AudioMixer mixer;
    void Start() {
        InitAudio();
    }

    // Update is called once per frame
    void Update() {

    }

    private void InitAudio() {
        if (PlayerPrefs.HasKey("MusicVolume")) {
            Debug.Log("[InitPlayerPrefs] -  Setting Player Music Volume To: " + PlayerPrefs.GetFloat("MusicVolume"));
            mixer.SetFloat("MusicVolume", Mathf.Log10(PlayerPrefs.GetFloat("MusicVolume")) * 20);
        }
        if (PlayerPrefs.HasKey("SoundEffectsVolume")) {
            Debug.Log("[InitPlayerPrefs] -  Setting Player Sound Effects Volume To: " + PlayerPrefs.GetFloat("SoundEffectsVolume"));
            mixer.SetFloat("SoundEffectsVolume", Mathf.Log10(PlayerPrefs.GetFloat("SoundEffectsVolume")) * 20);
        }
        if (PlayerPrefs.HasKey("VoiceVolume")) {
            Debug.Log("[InitPlayerPrefs] -  Setting Player Voice Volume To: " + PlayerPrefs.GetFloat("VoiceVolume"));
            mixer.SetFloat("VoiceVolume", Mathf.Log10(PlayerPrefs.GetFloat("VoiceVolume")) * 20);
        }
    }
}