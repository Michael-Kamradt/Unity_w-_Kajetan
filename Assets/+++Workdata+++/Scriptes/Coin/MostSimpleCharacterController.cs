using UnityEngine;
using UnityEngine.Rendering.Universal;

public class MostSimpleCharacterController : MonoBehaviour
{
    private Vector2 input;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] private CoinManager coinManager;
    [SerializeField] private UIManager uiManager;
    [SerializeField] private bool movment = true;

    void Update()
    {
        if (movment)
        {
            // Eingabe lesen (WASD oder Pfeiltasten)
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");

            // Bewegung berechnen
            Vector2 movement = new Vector2(input.x, input.y).normalized * (Time.deltaTime * moveSpeed);
            ;

            // Bewegung anwenden
            transform.Translate(movement);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger entered");

        if (other.CompareTag("Coin"))
        {
            coinManager.AddCoin();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("GameOver"))
        {
            movment = false;
            uiManager.GameOverPanelOn();
            
        }
        
    }
}