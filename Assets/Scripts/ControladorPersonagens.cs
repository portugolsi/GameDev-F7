using UnityEngine;

public class ControladorPersonagens : MonoBehaviour
{

    Animator anim; // Referência do nosso controlador de animações
    public float vida = 100;
    [SerializeField] float maxVida = 100;
    [SerializeField] float ataque = 10;
    [SerializeField] float delayAtaque = 1;
    [SerializeField] float curasDisponiveis = 5;
    public bool ehPlayer = true;
   
    // Start is called before the first frame update
    void Start()    
    {
         anim = GetComponentInChildren<Animator>(); // Linkando de forma automática o animator com a variável anim

        if (ehPlayer){
            HUD hud = GameObject.Find("HUD").GetComponent<HUD>(); //  Linkando de forma automática a HUD com a variável hud
            hud.telaDeCombate.SetActive(true);
            hud.OnCombatPanelActive.Invoke();  
            hud.botaoAtaque.onClick.AddListener(Ataque);
            hud.botaoCura.onClick.AddListener(Cura);

        }

    }


    public void Ataque(){

        // if (anim.GetBool("isAttacking")==false)
        if (!anim.GetBool("isAttacking")){
            anim.SetBool("isAttacking",true);
            Invoke("ResetAttack",delayAtaque);

        }

    }

    void ResetAttack()
    {
         anim.SetBool("isAttacking",false);
    }
    
    public void Cura(){
        print("O persongaem se curou");
    }
    
}
