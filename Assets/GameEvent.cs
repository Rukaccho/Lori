using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "GameEvent")]
public class GameEvent : ScriptableObject
{
    private List<IGameEventListener> eventListeners = new List<IGameEventListener>();

    public void Fire()
    {
        for (int i = 0; i < eventListeners.Count; i++)
        {
            IGameEventListener listener = eventListeners[i];
            listener.NotifyCustomInterface();
        }
    }

    public void RegisterListener(IGameEventListener gameEventListener)
    {
        if (gameEventListener == null)
            return;
        if (eventListeners.Contains(gameEventListener))
            return;

        eventListeners.Add(gameEventListener);
    }

    public void UnregisterListener(IGameEventListener gameEventListener)
    {
        if (gameEventListener == null)
            return;
        if (eventListeners.Contains(gameEventListener) == false)
            return;

        eventListeners.Remove(gameEventListener);
    }
}
