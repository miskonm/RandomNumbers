using System;
using UnityEngine;
using UnityEngine.UI;

namespace MagicNumbers.UI
{
    public class SelectionPanel : MonoBehaviour
    {
        [Header("Buttons")]
        [SerializeField] private Button yesNoScreenButton;
        [SerializeField] private Button numbersScreenButton;

        [Header("Screens")]
        [SerializeField] private Screen yesNoScreen;
        [SerializeField] private Screen numbersScreen;

        private Screen _currentOpenedScreen;

        private void Awake()
        {
            yesNoScreenButton.onClick.AddListener(YesNoButtonClicked);
            numbersScreenButton.onClick.AddListener(NumberButtonClicked);
        }

        private void Start()
        {
            YesNoButtonClicked();
        }

        private void NumberButtonClicked()
        {
            OpenScreen(numbersScreen);
        }

        private void YesNoButtonClicked()
        {
            OpenScreen(yesNoScreen);
        }

        private void OpenScreen(Screen screen)
        {
            if (_currentOpenedScreen == screen)
            {
                return;
            }

            if (_currentOpenedScreen != null)
            {
                _currentOpenedScreen.Hide();
            }

            _currentOpenedScreen = screen;
            _currentOpenedScreen.Show();
        }
    }
}
