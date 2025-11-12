using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melody : MonoBehaviour
{
    // Public variables
    public string melodyName;

    // Private variables
    [SerializeField] private List<MusicalCreature> creatures = new List<MusicalCreature>();

    public void AddCreature(MusicalCreature creature)
    {
        creatures.Add(creature);
        Debug.Log("Creature " + creature.creatureName + " added to melody " + melodyName);
    }

    public void RemoveCreature(MusicalCreature creature)
    {
        creatures.Remove(creature);
    }

    public void PlayMelody()
    {
        foreach (var creature in creatures)
        {
            creature.PlaySound();
        }
    }
}
