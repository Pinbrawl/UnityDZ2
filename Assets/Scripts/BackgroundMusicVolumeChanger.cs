using UnityEngine;
using UnityEngine.Audio;

public class BackgroundMusicVolumeChanger : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixer;

    private void Start()
    {
        _mixer.audioMixer.SetFloat("BackgroundMusicVolume", -80);
    }

    public void ChangeVolume(float volume)
    {
        _mixer.audioMixer.SetFloat("BackgroundMusicVolume", Mathf.Lerp(-80, 0, volume));
    }
}
