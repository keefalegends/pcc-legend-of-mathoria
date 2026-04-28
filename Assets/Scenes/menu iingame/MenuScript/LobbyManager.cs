using UnityEngine;
using TMPro; // Wajib untuk TextMeshPro

public class LobbyManager : MonoBehaviour
{
    public TMP_Text welcomeText; // Slot untuk narik teks di Inspector

    void Start()
    {
        // Ambil nama dari PlayerPrefs yang kita simpan tadi
        // "Player" adalah nama cadangan kalau datanya nggak ketemu
        string namaPlayer = PlayerPrefs.GetString("NamaUser", "Player");

        // Tampilkan ke layar
        welcomeText.text = "Welcome, " + namaPlayer + "!";
    }

    // Fungsi untuk pindah ke level tertentu (untuk tombol level nanti)
    public void PilihLevel(string namaLevel)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(namaLevel);
    }
}