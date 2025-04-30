using UnityEngine;
using UnityEngine.Audio;

public class SoundVolumeChanger : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixer;

    private bool _isEnable;
    private float _volume;

    private void Start()
    {
        _isEnable = true;
        _volume = 0;

        _mixer.audioMixer.SetFloat("SoundVolume", -80);
    }

    public void ChangeVolume(float volume)
    {
        _volume = volume;

        if(_isEnable)
            _mixer.audioMixer.SetFloat("SoundVolume", Mathf.Lerp(-80, 0, _volume));
        else
            _mixer.audioMixer.SetFloat("SoundVolume", -80);
    }

    public void SoundEnable(bool isEnable)
    {
        _isEnable = isEnable;

        if (_isEnable)
            _mixer.audioMixer.SetFloat("SoundVolume", Mathf.Lerp(-80, 0, _volume));
        else
            _mixer.audioMixer.SetFloat("SoundVolume", -80);
    }
}
