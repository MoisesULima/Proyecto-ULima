using UnityEngine;

public class GameManagerTopDown : MonoBehaviour
{
    // Creamos un campo (atributo) para que guarde las cerezas recogidas
    int cherries;

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
        Debug.Log("Cerezas: " + cherries);
    }
}
