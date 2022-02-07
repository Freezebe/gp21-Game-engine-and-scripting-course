using System;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [SerializeField] private GameEvent gameEvent;
    [SerializeField] private UnityEvent onGameEvent;

    private void OnEnable()
    {
        gameEvent.OnGameEvent += InvokeUnityEvent;
    }

    private void OnDisable()
    {
        gameEvent.OnGameEvent -= InvokeUnityEvent;
    }

    private void InvokeUnityEvent()
    {
        onGameEvent.Invoke();
    }
    
}
