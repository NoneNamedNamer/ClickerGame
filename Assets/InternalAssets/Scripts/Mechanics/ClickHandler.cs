using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Crrr
{
    public class ClickHandler : MonoBehaviour
    {
        public double score = 0;

        public void OnClick() => score++;
    }
}