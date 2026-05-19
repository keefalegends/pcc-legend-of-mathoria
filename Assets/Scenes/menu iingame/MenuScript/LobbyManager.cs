using UnityEngine;
using TMPro; // Wajib untuk TextMeshPro

public class LobbyManager : MonoBehaviour
{
    public TMP_Text welcomeText; // Slot untuk narik teks di Inspector
    public GameObject levelSelectPanel; // Slot untuk narik panel level select
    
    // Rename the field to avoid conflict with the method
    public GameObject CharacterSelectPanel;
    void Start()
    {
        // Ambil nama dari PlayerPrefs yang kita simpan tadi
        // "Player" adalah nama cadangan kalau datanya nggak ketemu
        string namaPlayer = PlayerPrefs.GetString("NamaUser", "Player");

        // Tampilkan ke layar
        welcomeText.text = "Welcome, " + namaPlayer + "!";
    }

    // Fungsi untuk pindah ke level tertentu (untuk tombol level nanti)

    public void BukaLevelSelect()
    {
        levelSelectPanel.SetActive(true); // Tampilkan panel level select
    }
    public void PilihLevel(string namaLevel)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(namaLevel);
        
    }

    public void KembaliKeMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MenuScene");
        levelSelectPanel.SetActive(false);
    }

    public void BukaMenuPilihKarakter()
    {
        // Langsung nyalakan panel pemilihan karakternya tanpa cek PlayerPrefs
        CharacterSelectPanel.SetActive(true);
    }


}