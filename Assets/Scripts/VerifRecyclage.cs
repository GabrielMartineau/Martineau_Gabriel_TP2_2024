using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerifRecyclage : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {   
        if(other.tag == "Recyclage" || other.tag == "Compost" || other.tag == "Poubelle"){  
            if(other.tag == "Recyclage"){
                Debug.Log("T'as mis l'objet au bon endroit!");
                Destroy(other.gameObject);
            }
            else{
                Debug.Log("Mauvais récipient");
                Destroy(other.gameObject);
            }
        }
    }
}
