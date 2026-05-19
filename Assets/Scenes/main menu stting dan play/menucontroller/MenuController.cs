using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuController : MonoBehaviour
{
    public GameObject panelSetting;
    public TMP_InputField inputNama; // Slot untuk narik InputField nanti
    public GameObject Credits;
    public GameObject howto;

    // 2. Fungsi buat nampilin panel pas tombol Credits diklik
    public void BukaCredits()
    {
        Credits.SetActive(true);
    }

    // 3. Fungsi buat ngumpetin panel pas tombol X merah diklik
    public void TutupCredits()
    {
        Credits.SetActive(false);
    }

    public void BukaHowTo()
    {
        howto.SetActive(true);
    }

    // 3. Fungsi buat ngumpetin panel pas tombol X merah diklik
    public void TutupHowTo()
    {
        howto.SetActive(false);
    }

    public void KeLogin()
        {
            SceneManager.LoadScene("LoginScene");
        }

    public void KembaliKeMenu()
    {
        SceneManager.LoadScene("awal login");
    }

    public void BukaSetting()
    {
        panelSetting.SetActive(true);
    }

    // Tadi typo di sini, sudah saya benerin jadi TutupSetting
    public void TutupSetting()
    {
        panelSetting.SetActive(false);
    }

    public void SimpanNamaDanMulai()
    {
        // Ambil teks dari InputField
        string namaPlayer = inputNama.text;

        // Cek dulu apakah nama kosong atau tidak (Opsional tapi bagus)
        if (!string.IsNullOrEmpty(namaPlayer))
        {
            Debug.Log("Nama Player: " + namaPlayer);
            PlayerPrefs.SetString("NamaUser", namaPlayer);
            PlayerPrefs.Save(); // Memastikan data benar-benar tersimpan

            // Pastikan kamu sudah punya scene bernama "GameScene" di Build Settings
            SceneManager.LoadScene("MenuScene");
        }
        else
        {
            Debug.LogWarning("Nama tidak boleh kosong!");
        }
    }
}