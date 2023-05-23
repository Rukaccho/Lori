using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListner : MonoBehaviour, IGameEventListener
{
    public GameEvent gameEventToListen;
    public UnityEvent response;

    private void OnEnable()
    {
        gameEventToListen.RegisterListener(this);
    }

    public void NotifyCustomInterface()
    {
        response?.Invoke();
    }

    private void OnDisable()
    {
        gameEventToListen.UnregisterListener(this);
    }
}
