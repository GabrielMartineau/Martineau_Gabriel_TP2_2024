using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SO/InfosLevel")]
public class InfosLevel : ScriptableObject
{
    public int nbrObjectsCollect;
    public int nbrObjectsRecupere;
    public int tempsRealisationNiveauSecondes;
    public AudioClip musiqueAmbianceNiveau;
}
