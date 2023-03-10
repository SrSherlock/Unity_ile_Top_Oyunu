using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerateTowards : MonoBehaviour
{
    // tüm düşmanları kendimize çekme

    [SerializeField]
    Transform transTowards;
    [SerializeField]
    float fSpeed;
    Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        if (transTowards == null)
        {
            transTowards = FindObjectOfType<AddPlayerControlledVelocity>().transform;
        }
    }
    void Update()
    {
        Vector3 v3MeTowardsTarget = transTowards.position - transform.position;
        rigid.velocity += v3MeTowardsTarget.normalized * fSpeed * Time.deltaTime;// time.delta sadece farklılıklardan ve oyun zamanından kurtulduğumuzudan emin olmak için
    }
}
