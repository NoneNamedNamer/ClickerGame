using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

namespace Crrr
{
    public class UIHandler : MonoBehaviour
    {
        public Text scoreText;
        public ClickHandler _clickHandler;

        private void Awake()
        {
            if (_clickHandler == null)
            {
                _clickHandler = GameObject.FindObjectOfType<ClickHandler>();
            }              
        }

        private void Update() => scoreText.text = $"Score: {_clickHandler.score}";
    }
}