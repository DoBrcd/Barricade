using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaricadeCore
{
    public class Plateau : MonoBehaviour
    {
        public Case finish;

        [ContextMenu("CreateBackLink")]
        public void CreateBackLink()
        {

            foreach (Case c in this.gameObject.GetComponentsInChildren<Case>())
            {
                c.CreateBackLink();
            }
        }
    }
}
