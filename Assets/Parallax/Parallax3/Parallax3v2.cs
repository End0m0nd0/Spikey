using UnityEngine;

public class Parallax3v2 : MonoBehaviour
{
    public float speed;
    private float x;

    void Update()
    {
        transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
        x = transform.position.x;
        if (x <= -57.6)
            transform.position = new Vector3(57.595f, 0f, 0f);
    }
}
