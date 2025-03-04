using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private SOCarInput carInput;
    [SerializeField] private Movement movement;

    private void Awake()
    {
        carInput.OnMovement += HandleMovementChange;
    }

    private void OnDisable()
    {
        carInput.OnMovement -= HandleMovementChange;
    }

    private void HandleMovementChange(Vector2 movementInput)
    {
        movement.SetDir(movementInput);
    }
}
