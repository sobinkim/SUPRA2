using DG.Tweening;
using System.Security;
using UnityEngine;
public class Movement : MonoBehaviour
{
    private Vector3 direction;
    [SerializeField] Rigidbody rigid;
    [SerializeField] CheckGroud checkGroud;

    [SerializeField] private float mass;
    [SerializeField] private float gravity;
    [SerializeField] private float max_km_Speed;
    [SerializeField] private float max_Time;
    [SerializeField] private float checkSpeed;
    [SerializeField] private bool isGroud = false;
    
    private float currentSpeed = 0;
    private float power;
    private float max_ms_Speed;

  
    bool isMove = true;
    bool isStoping = true;
    private void Start()
    {
        max_ms_Speed = max_km_Speed * (5f / 18f);
        print(max_ms_Speed);
    }
    public void SetDir(Vector2 dir)
    {
        direction = new Vector3(dir.x,0,dir.y);
        print(dir);
    }

    private void GetSpeed()
    {
        Vector3 vector = direction;
        if (vector != new Vector3(0,0,0))
        {
           if(isMove)
            {
                DOTween.To(() => currentSpeed, x => currentSpeed = x, max_ms_Speed, max_Time)
                 .SetEase(Ease.InCubic);//똑같은게 반복 실행

            }
            isMove = false;
        }
        else 
        {
            isMove = true;
            if (isStoping)
            {
                DOTween.To(() => currentSpeed, x => currentSpeed = x, 0, 3)
                .SetEase(Ease.OutQuad);
            }

            isStoping = false;
        }
     
    }

    public void Calculator_Move()
    {
        power = mass * currentSpeed;
        if(isGroud)
        rigid.AddForce(direction * power, ForceMode.Force);

    }

    private void Update()
    { 
        GetSpeed();//
       isGroud = checkGroud.GetisGround();
        checkSpeed = 10*3.6f;
    }

    private void FixedUpdate()
    {
        Calculator_Move();
    }

    

}
