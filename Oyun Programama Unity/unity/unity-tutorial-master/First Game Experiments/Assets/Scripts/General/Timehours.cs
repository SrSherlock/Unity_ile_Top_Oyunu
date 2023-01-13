using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Timehours : MonoBehaviour
{
    public Text sayactext;
    int sayacstart = 0;

    void Start()
    {
        StartCoroutine(zamanuret());
    }

    void Update()
    {
        sayactext.text = "Time: " + sayacstart;

    }
    IEnumerator zamanuret()
    {
        yield return new WaitForSeconds(1);
        while (true)
        {
            sayacstart++;
            yield return new WaitForSeconds(1);
        }
    }
}
