using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    
    public Button botaoAtaque;  // Vou referenciar o botão de ataque
    public Button botaoCura;  // Vou referenciar o botão de cura
    public GameObject telaDeCombate;  // Vou referenciar o painel de combate

    public UnityEvent OnCombatPanelActive;

}
