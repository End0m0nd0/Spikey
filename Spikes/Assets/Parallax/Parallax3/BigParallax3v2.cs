using UnityEngine;

public class BigParallax3v2 : MonoBehaviour
{
    public float speed;
    private float x;

    void Update()
    {
        transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
        x = transform.position.x;
        if (x <= -2438)
            transform.position = new Vector3(3322f, 248.5f, 0f);
    }
}
