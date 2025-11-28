using UnityEngine;
using UnityEngine.UIElements;

public class Stage1Manager : MonoBehaviour
{
    public static bool isRed;
    public static bool isGreen;
    public static bool isBlue;

    public GameObject Door;

    float destroyCooldown = 5f;

    [SerializeField] private bool currentRed = false;
    [SerializeField] private bool currentGreen =false;
    [SerializeField] private bool currentBlue = false;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       currentRed = isRed;
       currentGreen = isGreen;
       currentBlue = isBlue;

       if (currentRed == true && currentGreen == true && currentBlue == true)
        {
            Destroy(Door ,destroyCooldown);
        }
        else { }
    }
}
