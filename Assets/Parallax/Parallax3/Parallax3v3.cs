using UnityEngine;

public class Parallax3v3 : MonoBehaviour
{
    public float speed;
    private float x;

    void Update()
    {
        transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
        x = transform.position.x;
        if (x <= -38.4)
            transform.position = new Vector3(38.395f, 0f, 0f);
    }
}
