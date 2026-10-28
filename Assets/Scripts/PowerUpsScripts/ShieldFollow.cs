using UnityEngine;

public class ShieldFollow : MonoBehaviour
{
    GameObject[] bird;
    void Start()
    {
        bird = GameObject.FindGameObjectsWithTag("Ball");
    }

    void Update()
    {
        transform.position = new Vector3(bird[0].transform.position.x, bird[0].transform.position.y);
    }
}
