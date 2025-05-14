using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;

    void Update()
    {
        if (!GameManager.Instance.IsGameStarted || GameManager.Instance.IsGameOver)
            return;

        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        if (transform.position.x < -20f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.GameOver();
        }
    }
}
