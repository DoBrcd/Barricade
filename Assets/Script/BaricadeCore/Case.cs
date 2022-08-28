using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaricadeCore
{
    public class Case : MonoBehaviour
    {
        public Case up, down, left, right;
        public GameObject upGo, downGo, leftGo, rightGo;

        Bille bille;
        bool isOccupied
        {
            get
            {
                return (bille != null && bille is Baricade);
            }
        }

        public void Start()
        {
            PlaceCylinder();
        }

        [ContextMenu("CreateBackLink")]
        public void CreateBackLink()
        {
            if (up)
                up.down = this;
            if (down)
                down.up = this;
            if (left)
                left.right = this;
            if (right)
                right.left = this;

            Debug.Log("It's ok !");

            PlaceCylinder();
        }

        public bool IsOccupied()
        {
            return isOccupied;
        }

        public List<Case> GetAvailableCases(int distance, Case from = null)
        {
            List<Case> cases = new List<Case>();

            if (distance == 1)
            {
                cases.Add(this);
            }
            else if (this.IsOccupied())
            {
                return cases;
            }
            else
            {
                if (up != null && from != up)
                {
                    cases.AddRange(up.GetAvailableCases(distance - 1, this));
                }
                if (down != null && from != down)
                {
                    cases.AddRange(down.GetAvailableCases(distance - 1, this));
                }
                if (left != null && from != left)
                {
                    cases.AddRange(left.GetAvailableCases(distance - 1, this));
                }
                if (right != null && from != right)
                {
                    cases.AddRange(right.GetAvailableCases(distance - 1, this));
                }
            }

            return cases;
        }

        public void PlaceCylinder()
        {
            upGo.SetActive(up != null);
            downGo.SetActive(down != null);
            leftGo.SetActive(left != null);
            rightGo.SetActive(right != null);

            if (up)
            {
                Transform cylindre = upGo.transform.GetChild(0);
                cylindre.position = (this.transform.position + up.transform.position) / 2 + new Vector3(0, 0.15f, 0);
                cylindre.localScale = new Vector3(0.5f, Vector3.Distance(this.transform.position, up.transform.position) / 2, 0.1f);
            }
            if (down)
            {
                Transform cylindre = downGo.transform.GetChild(0);
                cylindre.position = (this.transform.position + down.transform.position) / 2 + new Vector3(0, 0.15f, 0);
                cylindre.localScale = new Vector3(0.5f, Vector3.Distance(this.transform.position, down.transform.position) / 2, 0.1f);
            }
            if (left)
            {
                Transform cylindre = leftGo.transform.GetChild(0);
                cylindre.position = (this.transform.position + left.transform.position) / 2 + new Vector3(0, 0.15f, 0);
                cylindre.localScale = new Vector3(0.5f, Vector3.Distance(this.transform.position, left.transform.position) / 2, 0.1f);
            }
            if (right)
            {
                Transform cylindre = rightGo.transform.GetChild(0);
                cylindre.position = (this.transform.position + right.transform.position) / 2 + new Vector3(0, 0.15f, 0);
                cylindre.localScale = new Vector3(0.5f, Vector3.Distance(this.transform.position, right.transform.position) / 2, 0.1f);
            }
        }
    }
}