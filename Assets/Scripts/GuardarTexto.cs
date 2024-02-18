using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GuardarTexto : MonoBehaviour
{
    public InputField inputField;

    private void Start()
    {
        // Cargar el nombre de usuario si existe solo en la escena actual
        if (SceneManager.GetActiveScene().name == "Usuario")
        {
            if (PlayerPrefs.HasKey("NombreUsuario"))
            {
                string nombreUsuarioGuardado = PlayerPrefs.GetString("NombreUsuario");
                inputField.text = nombreUsuarioGuardado;
            }
        }
    }

    public void GuardarNombreUsuario()
    {
        string nombreUsuario = inputField.text;

        // Guardar el nombre de usuario solo en la escena actual
        if (SceneManager.GetActiveScene().name == "Usuario")
        {
            PlayerPrefs.SetString("NombreUsuario", nombreUsuario);
            PlayerPrefs.Save();
        }
    }
}

