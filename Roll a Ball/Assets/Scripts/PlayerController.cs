using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    public float speed=100;
    private int count;
    public Text countText;
    public Text winText;
     
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();

               
    }

  
    void FixedUpdate() //Physics Functionalitites
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed); 
    }

    

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag ("Pickup"))
        {
            other.gameObject.SetActive(false);
            count = count+1;
            SetCountText();
        }
    }
    IEnumerator MyIEnumerator()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void SetCountText()
    {
        //Debug.Log(gameObject.name);
        countText.text = "Count : " + count;
        if (count >=13)
        {
            winText.text= "You Win ";
            StartCoroutine(MyIEnumerator());
        }
        

    }

}
