using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private GameObject m_Target = null;

    private Vector3 _Direction = new Vector3(0.0f, 0.0f, 0.0f);

    private float _MoveSpeed = 3.0f;

    private bool _bCheckTrigger = false;


    private void Start()
    {
        Destroy(gameObject, 5.0f);
    }

    private void Update()
    {
        MoveBullet();
    }

    public void Initialize(Vector3 TargetPos)
    {
        _Direction = TargetPos - transform.position;
        _Direction.Normalize();
    }

    private void MoveBullet()
    {
        transform.Translate(_Direction * Time.deltaTime * _MoveSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _bCheckTrigger = true;
            Destroy(gameObject);
        }
    }

}
