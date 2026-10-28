using UnityEngine;

public class BigParallax1 : MonoBehaviour
{
    public float speed;
    private float x;

    void Update()
    {
        transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
        x = transform.position.x;
        if (x <= -682f)
            transform.position = new Vector3(1566f, 248.5f, 0f);
    }
}
