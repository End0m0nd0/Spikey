using UnityEngine;

public class BigParallax4 : MonoBehaviour
{
    public float speed;
    private float x;

    void Update()
    {
        transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
        x = transform.position.x;
        if (x <= -457)
            transform.position = new Vector3(1341, 248.5f, 0f);
    }
}
