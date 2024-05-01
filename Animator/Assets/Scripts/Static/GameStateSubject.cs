using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateSubject
{
    GameState _gameState;

    public delegate void OnGameStateChange(GameState newState);
    public event OnGameStateChange GameStateChanged;

    public GameState CurrentGameState
    {
        get { return _gameState; }
        set
        {
            if (_gameState != value)
            {
                _gameState = value;
                NotifyObservers();
            }
        }
    }

    private void NotifyObservers()
    {
        GameStateChanged?.Invoke(_gameState);
    }
}

