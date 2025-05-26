using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSoundPlayer : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private AudioClip _sound;

    public event Action<AudioClip> Playing;

    private void OnEnable()
    {
        _button.onClick.AddListener(Play);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(Play);
    }

    private void Play()
    {
        Playing?.Invoke(_sound);
    }
}
