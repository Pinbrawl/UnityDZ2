using UnityEngine;
using UnityEngine.Audio;

public class MasterVolumeChanger : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixer;

    private void Start()
    {
        _mixer.audioMixer.SetFloat("MasterVolume", -80);
    }

    public void ChangeVolume(float volume)
    {
        _mixer.audioMixer.SetFloat("MasterVolume", Mathf.Lerp(-80, 0, volume));
    }
}
