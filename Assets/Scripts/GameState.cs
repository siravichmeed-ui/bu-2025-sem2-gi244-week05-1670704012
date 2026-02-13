using UnityEngine;

public class GameState : MonoBehaviour
{
    public int hitCount = 0;
    public const string ENEMT_TAG = "Enemy";
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            hitCount++;
        }

        if (hitCount >= 5)
        {
            Debug.Log("Game OVER");
            Time.timeScale = 0f;
        }
    }
}
