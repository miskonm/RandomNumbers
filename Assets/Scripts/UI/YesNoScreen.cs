using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

namespace MagicNumbers.UI
{
    public class YesNoScreen : Screen
    {
        [SerializeField] private Button startCalculationButton;
        [SerializeField] private TextMeshProUGUI resultLabel;

        private void Awake()
        {
            startCalculationButton.onClick.AddListener(CalculateResult);
        }

        private void CalculateResult()
        {
            resultLabel.text = GetYesNoResult();
        }

        private string GetYesNoResult()
        {
            var result = Random.Range(1, 3);

            return result == 1 ? "Yes" : "No";
        }
    }
}
