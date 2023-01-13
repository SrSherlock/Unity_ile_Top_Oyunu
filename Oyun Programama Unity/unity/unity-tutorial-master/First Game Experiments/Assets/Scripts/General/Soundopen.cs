using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundopen : MonoBehaviour
{
   public void sesac()
    {
        AudioListener.pause = false;
    }
    public void seskapa()
    {
        AudioListener.pause = true;
    }
}
