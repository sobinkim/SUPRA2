using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector2 direction;
    [SerializeField] Rigidbody rigid;

    public void SetDir(Vector2 dir)
    {
        direction = dir;
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
