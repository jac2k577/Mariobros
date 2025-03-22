using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class RegresoController2 : MonoBehaviour
{
    private UIDocument uiRegreso;
    private Button botonRegreso;

    void OnEnable()
    {
        uiRegreso = GetComponent<UIDocument>();
        var root = uiRegreso.rootVisualElement;
        botonRegreso = root.Q<Button>("BotonRegreso");
        botonRegreso.RegisterCallback<ClickEvent>(Regresar);
    }

    private void Regresar(ClickEvent evt)
    {
        SceneManager.LoadScene("menu");
    }
}
