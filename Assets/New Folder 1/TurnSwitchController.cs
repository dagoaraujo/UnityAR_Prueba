using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TurnSwitchController : MonoBehaviour
{
    public ActionBasedSnapTurnProvider SnapturnProvider;
    public ActionBasedContinuousTurnProvider continuousTurnProvider;

    public bool SnapTurnActive = true;

    private void Awake()
    {
        SwitchTurn();
    }

    [ContextMenu("Ejecutar -> SwitchTurn")]

    public void SwitchTurn()
    {
        if (SnapTurnActive == true) //Si SNAP verdadero -> Activar continuous
        {
            SnapturnProvider.turnAmount = 0;
            continuousTurnProvider.turnSpeed = 60;
            SnapTurnActive = false;
        }

        else if (SnapTurnActive == false) // Si SNAP falso -> Desactivar continuous
        {
            SnapturnProvider.turnAmount = 15;
            continuousTurnProvider.turnSpeed = 0;
            SnapTurnActive = true;
        }
    }
}
