using UnityEngine;

public class GestionnaireMenu : MonoBehaviour
{
   [SerializeField] private GameObject panneauSon;

   private bool isMenuOn = false;

   public void OnMenu(){
        if(isMenuOn == false){
            panneauSon.SetActive(true);
            isMenuOn = true;
        }
        else{
            panneauSon.SetActive(false);
            isMenuOn = false;
        }
   }
}
