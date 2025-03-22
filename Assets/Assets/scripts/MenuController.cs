using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuController : MonoBehaviour
{
    private UIDocument menu;
    private Button botonJugar;
    private Button botonAyuda;
    private Button botonCreditos;
    private Button closeButton;
    private VisualElement helpMenu;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        // Referencias a los botones
        botonJugar = root.Q<Button>("btn-jugar");
        botonAyuda = root.Q<Button>("btn-ayuda");
        botonCreditos = root.Q<Button>("btn-creditos");
        closeButton = root.Q<Button>("close-help");

        // Referencia al menú de ayuda
        helpMenu = root.Q<VisualElement>("help-menu");

        // Asignación de eventos de clic
        botonJugar.RegisterCallback<ClickEvent>(evt => CargarEscena("SampleScene2"));
        botonAyuda.RegisterCallback<ClickEvent>(evt => MostrarAyuda());
        botonCreditos.RegisterCallback<ClickEvent>(evt => CargarEscena("creditos2"));
        closeButton.RegisterCallback<ClickEvent>(evt => CerrarAyuda());
    }

    private void CargarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

   private void MostrarAyuda()
{
    helpMenu.style.display = DisplayStyle.Flex;
    helpMenu.Q<Label>("help-text").text = "¡Hola! Bienvenido al menú de ayuda del juego de Mario Bros.\n\n" +
        "Este es un juego creado en Unity para practicar el uso de funciones básicas, interfaces gráficas y elementos interactivos.\n\n" +
        "El objetivo principal es experimentar con el motor de Unity y aprender a crear juegos sencillos, utilizando conceptos fundamentales de diseño y programación.\n\n" +
        "¡Explora este juego basico y si tienes alguna duda hazlo sabes al correo A01800766@tec.mx!\n\n" +
        "¡Diviértete y disfruta de la experiencia!";
}


    private void CerrarAyuda()
    {
        helpMenu.style.display = DisplayStyle.None;
    }
}
