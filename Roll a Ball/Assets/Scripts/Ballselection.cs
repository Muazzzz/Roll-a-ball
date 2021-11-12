using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ballselection : MonoBehaviour
{
    // int BallNo;
    int x = 1;
    public void Ball(int a)
    {
        Debug.Log("Ball "+ a+x + " is Selected");
        PlayerPrefs.SetInt("BallNo", a);
       
    }

    public void Ground(int b)
    {
        Debug.Log("Ground " + b+x + " is Selected");
        PlayerPrefs.SetInt("GroundNo", b);

    }




}






