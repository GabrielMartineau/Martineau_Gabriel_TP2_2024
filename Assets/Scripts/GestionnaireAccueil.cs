using UnityEngine;
using TMPro;

public class GestionnaireAccueil : MonoBehaviour
{
    [SerializeField]
    private InfosJoueur so_infosJoueur;

    [SerializeField]
    private TMP_InputField champNomJoueur; 

    [SerializeField]
    private TMP_InputField champNomMonde; 

    [SerializeField]
    private GestionnaireScene gestionnaireScene;

    // Start is called before the first frame update
    void Start()
    {
        so_infosJoueur.nomJoueur = "";
        so_infosJoueur.nomMonde = "";
    }


    public void ChangementNom(string nom){
        so_infosJoueur.nomJoueur = nom;
    }
    public void ChangementNomMonde(string nom){
        so_infosJoueur.nomMonde = nom;
    }

    public void VerifNom(){
        if(champNomJoueur.text == ""){
            Debug.LogWarning("Le nom du joueur n'est pas valide");
            champNomJoueur.placeholder.GetComponent<TMP_Text>().text = "Votre nom?????????";
        }
        if(champNomMonde.text == ""){
            Debug.LogWarning("Le nom du monde n'est pas valide");
            champNomMonde.placeholder.GetComponent<TMP_Text>().text = "Votre monde????????";
        }
        else{
            gestionnaireScene.ChangeScene("Jeu");
        }
    }


}

