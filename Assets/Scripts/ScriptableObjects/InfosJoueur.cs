using UnityEngine;

[CreateAssetMenu(fileName = "InfosJoueur", menuName = "SO/NouveauJoueur")]
public class InfosJoueur : ScriptableObject
{
    public string nomJoueur;
    public string nomMonde;
    public int nbVie;
    public int score;
}
