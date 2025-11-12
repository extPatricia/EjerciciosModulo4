using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicalCreature : MonoBehaviour
{
    // Public variables
    public string creatureName;

    // Private variables
    [SerializeField] private float toneFrequency = 1f;
    [SerializeField] private float volumeLevel = 1f;

    public void PlaySound()
    {
        Debug.Log("" + creatureName + " is playing a sound at " + toneFrequency + " Hz with volume " + volumeLevel + " ");
    }

    public float GetToneFrequency()
    {
        return toneFrequency;
    }

    public float GetVolumeLevel()
    {
        return volumeLevel;
    }
}
