using UnityEngine;
using UnityEngine.UI;

public class SoundEnabler : MonoBehaviour
{
    [SerializeField] private Toggle _toggle;
    [SerializeField] private VolumeChanger _volumeChanger;

    private void OnEnable()
    {
        _toggle.onValueChanged.AddListener(Enable);
    }

    private void OnDisable()
    {
        _toggle.onValueChanged.RemoveListener(Enable);
    }

    public void Enable(bool isEnable)
    {
        _volumeChanger.SoundEnable(isEnable);
    }
}
