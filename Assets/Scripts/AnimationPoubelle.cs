using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPoubelle : MonoBehaviour
{

    [SerializeField]
    private GameObject poubelle;

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
        poubelle.GetComponent<Animator>().SetTrigger("Ouvrir");
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.CompareTag("Player")){
        poubelle.GetComponent<Animator>().SetTrigger("Fermer");
        }
    }
}
