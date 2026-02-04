using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public void Jugar ()
   {
        SceneManager.LoadScene("SERGI_TEST");

   }
    public void Salir()
    {
        Application.Quit();
        Debug.Log("El juego se cierra aquí");
    }
}
