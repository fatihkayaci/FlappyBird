using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    public GameObject[] numberPrefabs; // 0'dan 9'a kadar olan sayýlarý temsil eden prefab'ler
    public Transform scoreParent; // Skorun gösterileceði parent nesne

    private List<GameObject> currentDigits = new List<GameObject>();

    void Start()
    {
        UpdateScoreDisplay(0); // Baþlangýç skoru
    }

    public void UpdateScoreDisplay(int score)
    {
        // Mevcut sayýlarý temizle
        foreach (var digit in currentDigits)
        {
            Destroy(digit);
        }
        currentDigits.Clear();

        // Skoru karakter dizisine çevir
        char[] digits = score.ToString().ToCharArray();

        // Her bir karakteri prefab olarak ekle
        for (int i = 0; i < digits.Length; i++)
        {
            int digitValue = int.Parse(digits[i].ToString());
            GameObject digitPrefab = numberPrefabs[digitValue];
            GameObject digitObject = Instantiate(digitPrefab, scoreParent);

            // Her bir sayýyý uygun konuma yerleþtirin
            digitObject.transform.localPosition = new Vector3(i * 1.0f, 0, 0); // Aralarýndaki mesafeyi ayarlayýn
            currentDigits.Add(digitObject);
        }
    }
}

