using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICarState
{
    void EnterState(CarStateMachine state);
    void FixedUpdateState(CarStateMachine car);
    void UpdateState(CarStateMachine state);

    void ExiteState(CarStateMachine state);
}
