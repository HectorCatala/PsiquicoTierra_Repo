using UnityEngine;

public class PanelOpciones : MonoBehaviour
{
    public GameObject panelOpciones;

    public void AbrirOpciones()
    {
        panelOpciones.SetActive(true);
    }
    public void CerrarOpciones()
    {
        panelOpciones.SetActive(false);
    }

}
