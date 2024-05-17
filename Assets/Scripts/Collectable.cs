using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField]
    private CollectableObject pickUpObjectType;

    [SerializeField]
    private Transform joueurPosition;

    public GameEvent pickUpObjectEvent;

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            pickUpObjectEvent.Raise(this, pickUpObjectType.point);
            transform.SetParent(joueurPosition);
            transform.localPosition = new Vector3(0, 0, 2);
            transform.SetParent(joueurPosition, false);
        }
    }
}
