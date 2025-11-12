using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicalCreature : MonoBehaviour
{
    // Public variables
    public string creatureName;

    // Private variables
    [SerializeField] private float _toneFrequency = 1f;
    [SerializeField] private float _volumeLevel = 1f;

    public void PlaySound()
    {
        Debug.Log("" + creatureName + " is playing a sound at " + _toneFrequency + " Hz with volume " + _volumeLevel + " ");
    }

    public float GetToneFrequency()
    {
        return _toneFrequency;
    }

    public float GetVolumeLevel()
    {
        return _volumeLevel;
    }
}
