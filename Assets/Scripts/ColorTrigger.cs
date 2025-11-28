using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class ColorTrigger : MonoBehaviour
{

    public bool isRed;
    public bool isGreen;
    public bool isBlue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isRed = false;
        isGreen = false;    
        isBlue = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "R" && gameObject.tag == "BaseR")
        {
            isRed = true;
            Debug.Log("Pass");
        }
    }
}
