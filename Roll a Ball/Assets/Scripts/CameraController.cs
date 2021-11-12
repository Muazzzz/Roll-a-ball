using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject[] Player;
    public GameObject[] Ground;
     private Vector3 offset;
    
    private void Start()
    {
        
        offset = transform.position - Player[PlayerPrefs.GetInt("BallNo")].transform.position;
          Debug.Log(Player[PlayerPrefs.GetInt("BallNo")].transform.position);
        Player[PlayerPrefs.GetInt("BallNo")].SetActive(true);
      
        //Wall Selection

        Debug.Log(Ground[PlayerPrefs.GetInt("GroundNo")]);
        Ground[PlayerPrefs.GetInt("GroundNo")].SetActive(true);
    }


    public void LateUpdate()
    {
        transform.position = Player[PlayerPrefs.GetInt("BallNo")].transform.position + offset;
    }
   

    

}
