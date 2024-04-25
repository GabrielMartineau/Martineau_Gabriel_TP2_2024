using UnityEngine;
using TMPro;

public class GestionnaireNiveaux : MonoBehaviour
{
    [SerializeField]
    private InfosJoueur so_infosJoueur;

    [SerializeField]
    private TMP_Text champNomJoueur; 

    [SerializeField]
    private TMP_Text champNomMonde; 

    // Start is called before the first frame update
    void Start()
    {
        champNomJoueur.text = so_infosJoueur.nomJoueur;
    }

}
