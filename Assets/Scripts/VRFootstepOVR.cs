using UnityEngine;

public class VRFootstepOVR : MonoBehaviour
{
    public AudioSource footstepAudio;
    public float moveSpeedThreshold = 0.1f;
    public float stepInterval = 0.45f;

    private float timer;

    void Update()
    {
        
        float moveInputX = Input.GetAxis("Horizontal");
        float moveInputY = Input.GetAxis("Vertical");

        float moveAmount = Mathf.Abs(moveInputX) + Mathf.Abs(moveInputY);

        if (moveAmount > moveSpeedThreshold)
        {
            timer += Time.deltaTime;
            if (timer >= stepInterval)
            {
                footstepAudio.Play();
                timer = 0;
            }
        }
        else
        {
            timer = 0;
        }

        Debug.Log("Try Play Footstep");

    }
}
