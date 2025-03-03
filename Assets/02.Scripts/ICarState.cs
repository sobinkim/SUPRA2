using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICarState
{
    void EnterState(CarController car);
    void FixedUpdateState(CarController car);
    void UpdateState(CarController car);

    void ExiteState(CarController car);
}
