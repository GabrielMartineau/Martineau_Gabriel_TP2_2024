using UnityEngine;

[CreateAssetMenu(menuName = "SO/BonMauvaisObject")]
public class BonMauvaisObject : ScriptableObject
{
    public int pointBon;
    public int pointMauvais;
    public AudioClip sonBon;
    public AudioClip sonMauvais;
}
