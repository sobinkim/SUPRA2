using System;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "SO/CarInput", menuName = "SO/CarInput")]
public class SOCarInput : MonoBehaviour, Controls.ICarActions
{
    private Controls _controls;
    private Vector2 direction;

    public event Action<Vector2> OnMovement;
    private void OnEnable()
    {
        if (_controls == null)
        {
            _controls = new Controls();
            _controls.Car.SetCallbacks(this);
        }
        _controls.Car.Enable();
    }

    
    private void OnDisable()
    {
        _controls.Car.Disable();
    }

    public void OnWASD(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
        OnMovement?.Invoke(direction);


    }
}
