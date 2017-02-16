using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //public variables
    public float speed;
    public Text CountText;
    public Text WinText;

    //private variables
    private Rigidbody rb;
    private int count;
    

    //Start is called on the first frame that the scripts is active
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        WinText.text = "";
    }

    //Update is called before rendering a frame - most game code go here
    private void Update()
    {

    }

    //FixedUpdate - Is call just before any physics calculations - physics code go here
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }

    private void SetCountText()
    {
        CountText.text = "Points: " + count.ToString();
        if(count >= 12) WinText.text = "YOU WON!";
    }
}
