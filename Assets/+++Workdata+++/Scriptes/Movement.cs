using UnityEngine;
using UnityEngine.InputSystem; // Für das neue Input-System (Keyboard-Steuerung)

public class Movement : MonoBehaviour
{
    [SerializeField] private int speed = 10; // Geschwindigkeit, mit der sich die Kugel bewegt
    public GameObject sphere; // Referenz zur Kugel, die bewegt werden soll

    void Update()
    {
        // Wenn die W-Taste gedrückt wird → bewege die Kugel nach oben (Y+)
        if (Keyboard.current.wKey.isPressed)
        {
            sphere.transform.position += Vector3.up * (Time.deltaTime * speed);
        }

        // Wenn die A-Taste gedrückt wird → bewege die Kugel nach links (X-)
        if (Keyboard.current.aKey.isPressed)
        {
            sphere.transform.position += Vector3.left * (Time.deltaTime * speed);
        }

        // Wenn die S-Taste gedrückt wird → bewege die Kugel nach unten (Y-)
        if (Keyboard.current.sKey.isPressed)
        {
            sphere.transform.position += Vector3.down * (Time.deltaTime * speed);
        }

        // Wenn die D-Taste gedrückt wird → bewege die Kugel nach rechts (X+)
        if (Keyboard.current.dKey.isPressed)
        {
            sphere.transform.position += Vector3.right * (Time.deltaTime * speed);
        }
    }
}

