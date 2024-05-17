using UnityEngine;
using TMPro;

public class GestionnaireNiveaux : MonoBehaviour
{
    [SerializeField]
    private InfosJoueur so_infosJoueur;

    [SerializeField]
    private InfosLevel so_infosLevel;

    [SerializeField]
    private CollectableObject so_recyclage;

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
        so_infosJoueur.score = 0;
        champScore.text =  "Score : " + so_infosJoueur.score;
        so_infosJoueur.nbVie = 3;
        champPV.text = "Points de vie : " + so_infosJoueur.nbVie;
    }

    public void Perdu(){
        if(so_infosJoueur.nbVie == 0){
            gestionnaireScene.ChangeScene("Fin");
        }
    }

    public void PickupObject(Component sender, object data){
        Debug.Log("Pointage : " + data);
        so_infosLevel.nbrObjectsRecupere++;
        so_infosJoueur.score += so_recyclage.point;
        champScore.text = "Score : " + so_infosJoueur.score;
    }

    public void DepotObject(Component sender, object data){
        Debug.Log("Tu as déposé un objet");
        so_infosLevel.nbrObjectsCollect++;
        so_infosJoueur.score += 5;
        champScore.text = "Score : " + so_infosJoueur.score;
    }

    //if(sender.tag == "Recyclage"){} Pour les récipients

}
