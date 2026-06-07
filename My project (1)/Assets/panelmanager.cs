using UnityEngine;

public class panelmanager : MonoBehaviour
{
    public GameObject Main;
    public GameObject Option;

    public void ShowPanel1()
    {
        Main.SetActive(true);
        Option.SetActive(false);
    }

    public void ShowPanel2()
    {
        Main.SetActive(false);
        Option.SetActive(true);
    }
}
