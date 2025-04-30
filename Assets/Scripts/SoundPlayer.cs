using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _firstSound;
    [SerializeField] private AudioSource _secondSound;
    [SerializeField] private AudioSource _thirdSound;

    public void PlayFirst()
    {
        _secondSound.Stop();
        _thirdSound.Stop();
        _firstSound.Play();
    }

    public void PlaySecond()
    {
        _firstSound.Stop();
        _thirdSound.Stop();
        _secondSound.Play();
    }

    public void PlayThird()
    {
        _firstSound.Stop();
        _secondSound.Stop();
        _thirdSound.Play();
    }
}
