using UnityEngine;
using UnityEngine.Audio;

public class VolumeChanger : MonoBehaviour
{
    private const int MinVolume = -80;
    private const int MaxVolume = 0;

    [SerializeField] private AudioMixerGroup _mixer;
    [SerializeField] private string _explosedParameterName;

    private bool _isEnable;
    private float _volume;

    private void Start()
    {
        _isEnable = true;
        _volume = 0;

        _mixer.audioMixer.SetFloat(_explosedParameterName, MinVolume);
    }

    public void ChangeVolume(float volume)
    {
        _volume = volume;

        if(_isEnable)
            _mixer.audioMixer.SetFloat(_explosedParameterName, Mathf.Lerp(MinVolume, MaxVolume, _volume));
        else
            _mixer.audioMixer.SetFloat(_explosedParameterName, MinVolume);
    }

    public void SoundEnable(bool isEnable)
    {
        _isEnable = isEnable;

        if (_isEnable)
            _mixer.audioMixer.SetFloat(_explosedParameterName, Mathf.Lerp(MinVolume, MaxVolume, _volume));
        else
            _mixer.audioMixer.SetFloat(_explosedParameterName, MinVolume);
    }
}
