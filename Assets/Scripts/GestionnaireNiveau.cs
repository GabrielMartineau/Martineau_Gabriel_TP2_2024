using UnityEngine;
using TMPro;

public class GestionnaireNiveaux : MonoBehaviour
{
    [SerializeField]
    private InfosJoueur so_infosJoueur;

    [SerializeField]
    private GestionnaireScene gestionnaireScene;

    [SerializeField]
    private TMP_Text champNomJoueur; 
    
    [SerializeField]
    private TMP_Text champScore; 

    [SerializeField]
    private TMP_Text champNomMonde; 

    [SerializeField]
    private TMP_Text champPV; 

    // Start is called before the first frame update
    void Start()
    {
        champNomJoueur.text = so_infosJoueur.nomJoueur;
        champNomMonde.text = so_infosJoueur.nomMonde;
        champScore.text =  "Score : " + so_infosJoueur.score;

        champPV.text = "Points de vie : " + so_infosJoueur.nbVie;
    }

    void Perdu(){
        if(so_infosJoueur.nbVie == 0){
            gestionnaireScene.ChangeScene("Fin");
        }
    }

}
