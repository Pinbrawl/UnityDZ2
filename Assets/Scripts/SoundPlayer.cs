using UnityEngine;
using UnityEngine.UI;

public class SoundPlayer : MonoBehaviour
{
    [SerializeField] private Button _firstButton;
    [SerializeField] private Button _secondButton;
    [SerializeField] private Button _thirdButton;
    [SerializeField] private AudioClip _firstSound;
    [SerializeField] private AudioClip _secondSound;
    [SerializeField] private AudioClip _thirdSound;

    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        _firstButton.onClick.AddListener(PlayFirst);
        _secondButton.onClick.AddListener(PlaySecond);
        _thirdButton.onClick.AddListener(PlayThird);
    }

    public void PlayFirst()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_firstSound);
    }

    public void PlaySecond()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_secondSound);
    }

    public void PlayThird()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_thirdSound);
    }
}
