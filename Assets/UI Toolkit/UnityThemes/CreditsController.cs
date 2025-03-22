using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsController : MonoBehaviour
{
    public void OnCloseButtonClick()
    {
        SceneManager.LoadScene("menu");
    }
}
