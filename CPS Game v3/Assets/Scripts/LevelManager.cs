using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // just a filler line
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickStart()
    {
        SceneManager.LoadScene("Level01");
    }    public void OnClickExit()
    {
        print("Application will quit if on Windows or Mac");
        Application.Quit();
    }
}
