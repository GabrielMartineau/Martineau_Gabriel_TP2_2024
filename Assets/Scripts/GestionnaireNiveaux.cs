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
    private BonObject so_bonObject;

    [SerializeField]
    private MauvaisObject so_mauvaisObject;

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

    [SerializeField]
    private int nbrObjectsTotal; 

    public bool isHoldObject = false;

    // Start is called before the first frame update
    void Start()
    {
        champNomJoueur.text = so_infosJoueur.nomJoueur;
        champNomMonde.text = so_infosJoueur.nomMonde;
        so_infosLevel.nbrObjectsCollect = 0;
        so_infosLevel.nbrObjectsRecupere = 0;
        so_infosJoueur.score = 0;
        champScore.text =  "Score : " + so_infosJoueur.score;
        so_infosJoueur.nbVie = 3;
        champPV.text = "Points de vie : " + so_infosJoueur.nbVie;
    }

    void Update(){
        if(so_infosJoueur.nbVie == 0){
            gestionnaireScene.ChangeScene("Fin");
        }
        if(so_infosLevel.nbrObjectsCollect == nbrObjectsTotal){
            gestionnaireScene.ChangeScene("Fin");
        }
    }

    public void PickupObject(Component sender, object data){
        Debug.Log("Pointage : " + data);
        so_infosLevel.nbrObjectsRecupere++;
        so_infosJoueur.score += so_recyclage.point;
        champScore.text = "Score : " + so_infosJoueur.score;
        isHoldObject = true;
    }

    public void DepotBonObject(Component sender, object data){
        Debug.Log("Tu as déposé un objet");
        so_infosLevel.nbrObjectsCollect++;
        so_infosJoueur.score += so_bonObject.pointBon;
        champScore.text = "Score : " + so_infosJoueur.score;
        isHoldObject = false;
    }

    public void DepotMauvaisObject(Component sender, object data){
        Debug.Log("Tu as déposé un objet");
        so_infosLevel.nbrObjectsCollect++;
        so_infosJoueur.score += so_mauvaisObject.pointMauvais;
        champScore.text = "Score : " + so_infosJoueur.score;
        isHoldObject = false;
    }

}
