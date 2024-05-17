using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerifRecyclage : MonoBehaviour
{
    [SerializeField]
    private BonMauvaisObject depotObjectType;

    public GameEvent depotObjectEvent;
    private void OnTriggerEnter(Collider other) {   
        if(other.tag == "Recyclage" || other.tag == "Compost" || other.tag == "Poubelle"){  
            if(other.tag == "Recyclage"){
                depotObjectEvent.Raise(this, depotObjectType.pointBon);
                Debug.Log("T'as mis l'objet au bon endroit!");
                Destroy(other.gameObject);
            }
            else{
                depotObjectEvent.Raise(this, depotObjectType.pointMauvais);
                Debug.Log("Mauvais récipient");
                Destroy(other.gameObject);
            }
        }
    }
}
