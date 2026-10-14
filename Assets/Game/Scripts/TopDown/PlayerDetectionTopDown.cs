using UnityEngine;

public class PlayerDetectionTopDown : MonoBehaviour
{
    // Vamos a llamar a un método llamado OnTriggerEnter2D
    // Detecta si hemos pasado encima de un detector (Trigger)
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Pregunto a quién he detectado (en este caso las "Frutas")
        if (collision.CompareTag("Frutas"))
        {
            // Si hemos detectado una cereza (Fruta), entonces la destruimos
            // Vamos a destruir el objeto fruta (collision -> gameObject)
            Destroy(collision.gameObject);
        }
    }
}
