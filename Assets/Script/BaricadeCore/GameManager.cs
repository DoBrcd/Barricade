using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaricadeCore
{
    public class GameManager : MonoBehaviour
    {
        public Plateau plateau;
        public UIManager uiManager;
        private Dice dice = new Dice();

        public void LaunchDice()
        {
            int res = dice.Launch();
            uiManager.Score.text = res.ToString();
        }
    }
}
