using DG.Tweening;
using UnityEngine;
public class Movement : MonoBehaviour
{
    private Vector2 direction;
    [SerializeField] Rigidbody rigid;

    [SerializeField] private float mass;
    [SerializeField] private float gravity;
    [SerializeField] private float max_km_Speed;
    [SerializeField] private float max_Time;
    [SerializeField] private float checkSpeed;
    private float currentSpeed = 0;
    private float power;
    private float max_ms_Speed;

    private void Start()
    {
        max_ms_Speed = max_km_Speed * (5f / 18f);
        print(max_ms_Speed);
    }
    public void SetDir(Vector2 dir)
    {
     
        direction = dir;
        print(dir);
    }

    private void GetSpeed()
    {
        Vector2 vector = direction;
        if (vector.magnitude != 0)
        {
            DOTween.To(() => currentSpeed, x => currentSpeed = x, max_ms_Speed, max_Time)
              .SetEase(Ease.InCubic);
         
        
        }
        else if (vector.magnitude == 0)
        {
            DOTween.To(() => currentSpeed, x => currentSpeed = x, 0, 2)
           .SetEase(Ease.OutQuad);
         

        }
        else if (rigid.velocity.magnitude == 0)
        {
            rigid.velocity = Vector3.zero;
         
        }


    }

    public void Calculator_Move()
    {
        power = mass * currentSpeed;
        rigid.AddForce(direction * power, ForceMode.Force);

    }

    private void Update()
    {
       
        GetSpeed();
        checkSpeed = currentSpeed;
    }

    private void FixedUpdate()
    {
        Calculator_Move();
    }


}
