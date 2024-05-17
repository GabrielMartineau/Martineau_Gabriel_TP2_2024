using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField]
    private CollectableObject pickUpObjectType;

    public GameEvent pickUpObjectEvent;

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            pickUpObjectEvent.Raise(this, pickUpObjectType.point);
        }
    }
}
