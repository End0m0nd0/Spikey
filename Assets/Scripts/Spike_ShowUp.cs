using UnityEngine;

public class Spike_ShowUp : MonoBehaviour
{
    private bool right;

    void Start()
    {
        right = false;
        if (transform.position.x > 0) right = true;
    }

    void Update()
    {
        if (right)
            if (transform.position.x > 8.4f)
                transform.position -= new Vector3(3*Time.deltaTime, 0f, 0f);
        if (!right)
            if (transform.position.x < -8.4f)
                transform.position += new Vector3(3*Time.deltaTime, 0f, 0f);
    }
}
