using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGroud : MonoBehaviour
{
    [SerializeField] private Transform parentTransform;
    [SerializeField] private float distance;
    [SerializeField] private LayerMask targetLayer;
    private void Start()
    {

    }

    bool isGroud;
    private void Update()
    {
        Debug.DrawRay(parentTransform.transform.position, -(Vector2.up) * distance, Color.red);
        isGroud = Physics.Raycast(parentTransform.position, -(Vector2.up), distance, targetLayer) ? true : false;
        print(isGroud);
    }
    public bool GetisGround()
    {
        return isGroud;


    }
}
