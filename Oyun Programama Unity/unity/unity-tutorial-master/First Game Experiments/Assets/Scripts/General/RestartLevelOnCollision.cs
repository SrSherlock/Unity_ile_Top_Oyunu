using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelOnCollision : MonoBehaviour
{
    [SerializeField]
    string strTag;

    int playerhealt = 3;
    List<GameObject> canresim = new List<GameObject>();
    int i = 0;
    GameObject Can;
    GameObject Can1;
    GameObject Can2;
    GameObject Can3;
    GameObject Can4;
    GameObject Can5;
    GameObject Can6;
    GameObject Can7;
    GameObject Can8;
    

    void Start()
    {
        Can = GameObject.Find("can");
        Can1 = GameObject.Find("can1");
        Can2 = GameObject.Find("can2");
        Can3 = GameObject.Find("can3");
        Can4 = GameObject.Find("can4");
        Can5 = GameObject.Find("can5");
        Can6 = GameObject.Find("can6");
        Can7 = GameObject.Find("can7");
        Can8 = GameObject.Find("can8");
        canresim.Add(Can);
        canresim.Add(Can1);
        canresim.Add(Can2);
        canresim.Add(Can3);
        canresim.Add(Can4);
        canresim.Add(Can5);
        canresim.Add(Can6);
        canresim.Add(Can7);
        canresim.Add(Can8);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)
        {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);        
        }
        playerhealt--;
        Destroy(canresim[i]);
        i++;
        if (i==9)
        {
            System.Console.WriteLine("düşman göreviniz tamamlandı...");
        }
    }
}
