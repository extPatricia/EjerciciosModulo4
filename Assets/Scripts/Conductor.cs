using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conductor : MonoBehaviour
{
    // Public variables
    public string conductorName;

    // Private variables
    [SerializeField] private Melody _currentMelody;

    void Start()
    {
        StartConcert();
    }

    public void SetMelody(Melody melody)
    {
        _currentMelody = melody;
    }

    public void StartConcert()
    {
        if (_currentMelody != null)
        {
            Debug.Log("Conductor " + conductorName + " is starting the concert with melody " + _currentMelody.melodyName);
            _currentMelody.PlayMelody();
        }
    }
}
