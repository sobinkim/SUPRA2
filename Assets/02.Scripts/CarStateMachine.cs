using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class CarStateMachine : MonoBehaviour
{
    private ICarState CurrentState;
    private void Start()
    {
        ChangeState(new StopState());
    }
    public void ChangeState(ICarState NewState)
    {
        CurrentState?.ExiteState(this);
        CurrentState = NewState;
        CurrentState.EnterState(this);
    }

    private void Update()
    {
        CurrentState.UpdateState(this);
    }

    private void FixedUpdate()
    {
        CurrentState.FixedUpdateState(this);
    }
}