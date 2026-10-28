using UnityEngine;

public class BigParallax3v1 : MonoBehaviour
{
    public float speed;
    private float x;

    void Update()
    {
        transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
        x = transform.position.x;
        if (x <= -3398)
            transform.position = new Vector3(4282f, 248.5f, 0f);
    }
}
