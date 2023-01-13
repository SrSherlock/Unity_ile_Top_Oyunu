using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // boş bir gameobject içinde yukardan düşmanların spawn olması...
    [SerializeField]
    GameObject goCreate;

    [SerializeField]
    float fTimeIntervals;//saniye başı düşüş 

    [SerializeField]
    Vector3 v3SpawnPosJitter;//random 

    float fTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        fTimer = fTimeIntervals;
    }

    // Update is called once per frame
    void Update()
    {
        fTimer -= Time.deltaTime;
        if (fTimer <= 0)
        {
            // manuel olarak düşen cisimlerin kendimize çekme  
            fTimer = fTimeIntervals;

            Vector3 v3SpawnPos = transform.position;
            v3SpawnPos += Vector3.right * v3SpawnPosJitter.x * (Random.value - 0.5f);
            v3SpawnPos += Vector3.forward * v3SpawnPosJitter.z * (Random.value - 0.5f);
            v3SpawnPos += Vector3.up * v3SpawnPosJitter.y * (Random.value - 0.5f);

            Instantiate(goCreate, v3SpawnPos, Quaternion.identity);
        }
    }
}
