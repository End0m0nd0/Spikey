using UnityEngine;

public class BigParallax2 : MonoBehaviour
{
    public float speed;
    private float x;

    void Update()
    {
        transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
        x = transform.position.x;
        if (x <= -459f)
            transform.position = new Vector3(1343f, 248.5f, 0f);
    }
}
