using UnityEngine;
using UnityEngine.UI;

namespace _Scripts.Combat {
    public class PlayerCombatController : MonoBehaviour {
        [SerializeField] private Camera cam;
        [SerializeField] private GameObject battleMenu;
        private RaycastHit _hit, _enemy;

        // Bit shift for layer masks
        private int _layerMask = 1 << 9;
        private int _menuMask = 1 << 5;

        private void Awake() {
            // Invert the layer masks
            _layerMask = ~_layerMask;
            _menuMask = ~_menuMask;
            battleMenu.SetActive(false);
        }

        private void Update() {
            if (Input.GetMouseButtonDown(0)) {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out _hit, 100f, _layerMask)) {
                    _enemy = _hit;
                    battleMenu.transform.position = cam.WorldToScreenPoint(_hit.collider.transform.position);
                    battleMenu.SetActive(true);
                } else if (Physics.Raycast(ray, out _hit, 100f, _menuMask)) {
                    // TODO Setup to ignore the UI layer when it pops up
                }
            }
            if (_enemy.transform != null) {
                if (_enemy.transform.GetComponent<EnemyCombatController>().enemyHealth < 1) {
                    HideMenu();
                }
            }
        }

        public void HideMenu() {
            battleMenu.SetActive(false);
        }

        public void Option01() {
            Debug.Log("[PlayerCombatMenu] - Attack Option 1 " + _enemy.transform);
            _enemy.transform.GetComponent<EnemyCombatController>().AttackEnemy(1);
        }

        public void Option02() {
            Debug.Log("[PlayerCombatMenu] - Attack Option 2 " + _enemy.transform);
            _enemy.transform.GetComponent<EnemyCombatController>().AttackEnemy(2);
        }
    }
}
