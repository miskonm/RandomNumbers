using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MagicNumbers.UI
{
    public class RandomNumberScreen : Screen
    {
        [SerializeField] private Button startCalculationButton;
        [SerializeField] private TextMeshProUGUI resultLabel;

        [Header("Settings")]
        [SerializeField] private int startValue;
        [SerializeField] private int endValue;

        private void Awake()
        {
            startCalculationButton.onClick.AddListener(CalculateResult);
        }

        private void CalculateResult()
        {
            resultLabel.text = GetResult();
        }

        private string GetResult()
        {
            var result = Random.Range(startValue, endValue + 1);

            return result.ToString();
        }
    }
}
