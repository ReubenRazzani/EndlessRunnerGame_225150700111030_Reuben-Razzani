using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float resetPositionX;
    public float startPositionX;

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x <= resetPositionX)
        {
            transform.position = new Vector3(startPositionX, transform.position.y, transform.position.z);
        }
    }
}
