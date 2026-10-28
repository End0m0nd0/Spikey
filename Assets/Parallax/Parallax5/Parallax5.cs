using UnityEngine;

public class Parallax5 : MonoBehaviour
{
    public float speed;
    private float x;

    void Update()
    {
        transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
        x = transform.position.x;
        if (x <= -19.2f)
            transform.position = new Vector3(19.195f, 0f, 0f);
    }
}
