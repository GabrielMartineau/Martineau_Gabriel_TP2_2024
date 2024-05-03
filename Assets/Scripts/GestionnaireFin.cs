using UnityEngine;
using TMPro;

public class GestionnaireFin : MonoBehaviour
{
   [SerializeField]
    private InfosJoueur so_infosJoueur;

    [SerializeField]
    private TMP_Text champScore; 

    [SerializeField]
    private GestionnaireScene gestionnaireScene;

    // Start is called before the first frame update
    void Start()
    {
        champScore.text = "Score : " + so_infosJoueur.score;
    }

    public void RetourAccueil(){
        gestionnaireScene.ChangeScene("Accueil");
    }
}
