using UnityEngine;

public class Parallax2 : MonoBehaviour
{
    public float speed;
    private float x;

    void Update()
    {
        transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
        x = transform.position.x;
        if (x <= -25)
            transform.position = new Vector3(32.58f, 0f, 0f);
    }
}
