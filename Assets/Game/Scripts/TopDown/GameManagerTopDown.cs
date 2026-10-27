using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerTopDown : MonoBehaviour
{
    // Creamos un campo (atributo) para que guarde las cerezas recogidas
    int cherries;
    [SerializeField] TextMeshProUGUI textoCerezas;

    void Awake()
    {
        // Cuando comienza el juego no hay cerezas recogidas
        cherries = 0;
    }

    // Vamos a crear un método que me permita aumentar la cantidad de cerezas
    // un método público (public) para que pueda ser usado en otros lugares (scripts)
    public void AumentaCereza()
    {
        // Este código aumenta de 1 en 1 el contador de cerezas
        cherries++;
        textoCerezas.text = "x " + cherries;
        Debug.Log("Cerezas: " + cherries);
    }
}
