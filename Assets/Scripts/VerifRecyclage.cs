using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerifRecyclage : MonoBehaviour
{
    [SerializeField]
    private BonObject depotObjectBon;

    [SerializeField]
    private MauvaisObject depotObjectMauvais;

    [SerializeField]
    private GameEvent depotBonObjectEvent;

    [SerializeField]
    private GameEvent depotMauvaisObjectEvent;

    private void OnTriggerEnter(Collider other) {   
        if(other.tag == "Recyclage" || other.tag == "Compost" || other.tag == "Poubelle"){  
            if(other.tag == "Recyclage"){
                depotBonObjectEvent.Raise(this, depotObjectBon.pointBon);
                Debug.Log("T'as mis l'objet au bon endroit!");
                Destroy(other.gameObject);
            }
            else{
                depotMauvaisObjectEvent.Raise(this, depotObjectMauvais.pointMauvais);
                Debug.Log("Mauvais récipient");
                Destroy(other.gameObject);
            }
        }
    }
}
