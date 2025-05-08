using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeChanger : MonoBehaviour
{
    private const int MinVolume = -80;
    private const int MaxVolume = 0;

    [SerializeField] private AudioMixerGroup _mixer;
    [SerializeField] private Slider _slider;

    private bool _isEnable;
    private float _volume;

    private void Start()
    {
        _isEnable = true;
        _volume = 0;

        _mixer.audioMixer.SetFloat(_mixer.name, MinVolume);
    }

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(ChangeVolume);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(ChangeVolume);
    }

    public void ChangeVolume(float volume)
    {
        _volume = volume;

        if(_isEnable)
            _mixer.audioMixer.SetFloat(_mixer.name, Mathf.Lerp(MinVolume, MaxVolume, _volume));
        else
            _mixer.audioMixer.SetFloat(_mixer.name, MinVolume);
    }

    public void SoundEnable(bool isEnable)
    {
        _isEnable = isEnable;

        ChangeVolume(_volume);
    }
}
