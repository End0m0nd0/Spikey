using UnityEngine;

public class BigParallax3v3 : MonoBehaviour
{
    public float speed;
    private float x;

    void Update()
    {
        transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
        x = transform.position.x;
        if (x <= -1478)
            transform.position = new Vector3(2362f, 248.5f, 0f);
    }
}
