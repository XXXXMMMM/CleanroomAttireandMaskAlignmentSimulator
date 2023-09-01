using UnityEngine;

public class HelpUI : MonoBehaviour
{
    public GameObject helpPanel;

    private bool isShowing = false;

    private void Start()
    {
       
        helpPanel.SetActive(false);
    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.H))
        {
            if (!isShowing)
            {
                ShowHelpPanel();
            }
        }
        else
        {
            if (isShowing)
            {
                HideHelpPanel();
            }
        }
    }

    private void ShowHelpPanel()
    {
        helpPanel.SetActive(true);
        isShowing = true;
    }

    private void HideHelpPanel()
    {
        helpPanel.SetActive(false);
        isShowing = false;
    }
}
