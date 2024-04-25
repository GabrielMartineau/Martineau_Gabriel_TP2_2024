using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionnaireScene : MonoBehaviour
{
 public void ChangeScene(){
    SceneManager.LoadScene("Jeu");
 }
}
