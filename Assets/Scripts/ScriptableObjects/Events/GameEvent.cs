using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="SO/GameEvent")]
public class GameEvent : ScriptableObject
{
    // Nous déclarons une nouvelle liste qui va contenir les objets qui écoute les événements
    // Nous pouvons faire le parallèle avec une radio. Si personne ne syntonise le canal de la radio,
    // personne ne va réagir. Si une personne écoute la radio en syntonisant un poste de radio, 
    //elle peut réagir à ce qu'elle entend à la radio.
    public List<GameEventListener> eventListeners = new List<GameEventListener>();


    public void Raise() {
        Raise(null, null);
    }

    public void Raise(object data) {
        Raise(null, data);
    }

    public void Raise(Component sender) {
        Raise(sender, null);
    }

    public void Raise(Component sender, object data) {
          for (int i = eventListeners.Count -1; i >= 0; i--) {
            eventListeners[i].OnEventRaised(sender, data);
        }
    }

    // La méthode RegisterListener permet d'ajouter un objet qui écoute lorsque l'événement se déclenche.
    public void RegisterListener(GameEventListener listener) {
        if (!eventListeners.Contains(listener))
            eventListeners.Add(listener);
    }

    // La méthode UnregisterListener permet de désabonner un objet afin qu'il cesse d'écouter un événement.
    public void UnregisterListener(GameEventListener listener) {
        if (eventListeners.Contains(listener))
            eventListeners.Remove(listener);
    }

}
