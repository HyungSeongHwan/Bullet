using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{

    public GameObject m_Player = null;
    public GameObject m_TurretBody = null;
    public GameObject m_PrefabBullet = null;
    public GameObject m_FireStartPos = null;


    private void Start()
    {
        Initialize();
    }

    private void Update()
    {
        InputKey();
        RotationTurretBody();
    }


    private void Initialize()
    {
        
    }

    private void InputKey()
    {
        if (Input.GetMouseButtonDown(0)) FireBullet();
    }

    private void FireBullet()
    {
        GameObject goBullet = Instantiate(m_PrefabBullet);
        goBullet.transform.position = m_FireStartPos.transform.position;
        Bullet csBullet = goBullet.GetComponent<Bullet>();

        csBullet.Initialize(m_Player.transform.position);
        
    }

    private void RotationTurretBody()
    {
        m_TurretBody.transform.LookAt(m_Player.transform.position);
    }

}
