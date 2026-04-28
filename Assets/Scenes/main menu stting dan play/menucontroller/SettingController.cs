using UnityEngine;

public class SettingController : MonoBehaviour
{
    public GameObject panelSetting;

    public void BukaSetting()
    {
        panelSetting.SetActive(true);
    }

    public void TutupSetting()
    {
        panelSetting.SetActive(false);
    }   
}
