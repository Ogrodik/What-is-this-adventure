using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void NewScene (int num)
    {
        SceneManager.LoadScene (num);
    }

    public void Quit()
    {
        Application.Quit ();
    }
}
