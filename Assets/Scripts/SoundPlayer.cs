using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    [SerializeField] private List<ButtonSoundPlayer> _buttonSoundPlayers;

    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        foreach (ButtonSoundPlayer buttonSoundPlayer in _buttonSoundPlayers)
            buttonSoundPlayer.Playing += Play;
    }

    private void OnDisable()
    {
        foreach (ButtonSoundPlayer buttonSoundPlayer in _buttonSoundPlayers)
            buttonSoundPlayer.Playing -= Play;
    }

    public void Play(AudioClip sound)
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(sound);
    }
}
