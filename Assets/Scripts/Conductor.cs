using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conductor : MonoBehaviour
{
    // Public variables
    public string conductorName;

    // Private variables
    [SerializeField] private Melody currentMelody;

    void Start()
    {
        StartConcert();
    }

    public void SetMelody(Melody melody)
    {
        currentMelody = melody;
    }

    public void StartConcert()
    {
        if (currentMelody != null)
        {
            Debug.Log("Conductor " + conductorName + " is starting the concert with melody " + currentMelody.melodyName);
            currentMelody.PlayMelody();
        }
    }
}
