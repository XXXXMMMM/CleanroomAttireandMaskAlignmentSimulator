using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text helpText;
    public Text helpText2;

    void Start()
    {
        int difficulty = PlayerPrefs.GetInt("Difficulty", 0);

        if (difficulty == 0)
        {
            
            helpText.gameObject.SetActive(true);
            helpText2.gameObject.SetActive(true);
        }
        else
        {
           
            helpText.gameObject.SetActive(false);
            helpText2.gameObject.SetActive(false);
        }
    }
}
