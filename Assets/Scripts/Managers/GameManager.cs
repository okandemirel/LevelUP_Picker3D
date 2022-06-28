using System;
using Enums;
using Extentions;
using Keys;
using Signals;

public class GameManager : MonoSingleton<GameManager>
{
    #region Self Variables

    #region Public Variables

    public GameStates States;

    #endregion

    #endregion


    private void OnEnable()
    {
        SubscribeEvents();
    }


    private void SubscribeEvents()
    {
        CoreGameSignals.Instance.onChangeGameState += OnChangeGameState;
        CoreGameSignals.Instance.onSaveGameData += OnSaveGame;
    }

    private void UnsubscribeEvents()
    {
        CoreGameSignals.Instance.onChangeGameState -= OnChangeGameState;
        CoreGameSignals.Instance.onSaveGameData -= OnSaveGame;
    }

    private void OnDisable()
    {
        UnsubscribeEvents();
    }

    private void OnChangeGameState(GameStates newState)
    {
        States = newState;
    }

    private void OnSaveGame(SaveGameDataParams saveDataParams)
    {
        ES3.Save("Level", saveDataParams.Level);
        ES3.Save("Coin", saveDataParams.Coin);
        ES3.Save("SFX", saveDataParams.SFX);
        ES3.Save("VFX", saveDataParams.VFX);
        ES3.Save("Haptic", saveDataParams.Haptic);
    }
}