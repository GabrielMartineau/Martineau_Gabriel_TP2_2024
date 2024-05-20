using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerifCompost : MonoBehaviour
{
    [SerializeField]
    private BonObject depotObjectBon;

    [SerializeField]
    private AudioSource depotBon;

    [SerializeField]
    private AudioSource depotMauvais;

    [SerializeField]
    private MauvaisObject depotObjectMauvais;

    [SerializeField]
    private GameEvent depotBonObjectEvent;

    [SerializeField]
    private GameEvent depotMauvaisObjectEvent;

    private void OnTriggerEnter(Collider other) {   
        if(other.tag == "Recyclage" || other.tag == "Compost" || other.tag == "Poubelle"){  
            if(other.tag == "Compost"){
                depotBonObjectEvent.Raise(this, depotObjectBon.pointBon);
                depotBon.Play();
                Debug.Log("T'as mis l'objet au bon endroit!");
                Destroy(other.gameObject);
            }
            else{
                depotMauvaisObjectEvent.Raise(this, depotObjectMauvais.pointMauvais);
                depotMauvais.Play();
                Debug.Log("Mauvais récipient");
                Destroy(other.gameObject);
            }
        }
    }
}
