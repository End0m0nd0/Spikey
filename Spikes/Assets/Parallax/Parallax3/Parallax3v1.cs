using UnityEngine;

public class Parallax3v1 : MonoBehaviour
{
    public float speed;
    private float x;

    void Update()
    {
        transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
        x = transform.position.x;
        if (x <= -76.8)
            transform.position = new Vector3(76.795f, 0f, 0f);
    }
}
