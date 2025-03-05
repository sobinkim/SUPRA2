using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector2 direction;
    [SerializeField] Rigidbody rigid;
    private float _mass;
    private float _maxSD;

    private float _velocity;
    public void SetDir(Vector2 dir)
    {
        direction = dir;
    }
    public void Calculator()
    {

    }
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        rigid.AddForce(new Vector3(direction.x, direction.y, 0));
    }
}
